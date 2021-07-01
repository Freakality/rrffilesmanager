using Newtonsoft.Json;
using RRFFilesManager.Utils.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RRFFilesManager.Utils
{
    public static class Distance
    {
        // Handy structure for Long/Lat information 
        public struct Coords
        {
            public double Longitude;
            public double Latitude;
        }

        // Unit calculations 
        public enum Units
        {
            Miles,
            Kilometres
        }

        // Will return a null if the Google API is unable to find either post code, or the country constraint fails 
        // Google API Country Codes:
        //https://developers.google.com/custom-search/docs/xml_results_appendices#countryCodes
        public static double? BetweenTwoPostCodes(string postcodeA, string postcodeB, string countryCodeWithin = null, Units units = Units.Kilometres)
        {
            if (string.IsNullOrWhiteSpace(postcodeA) || string.IsNullOrWhiteSpace(postcodeB))
                return null;
            var ll1 = PostCodeToLongLat(postcodeA, countryCodeWithin);
            if (!ll1.HasValue) return null;
            var ll2 = PostCodeToLongLat(postcodeB, countryCodeWithin);
            if (!ll2.HasValue) return null;
            return ll1.Value.DistanceTo(ll2.Value, units);
        }

        // Uses the Google API to resolve a post code (within the specified country) 
        public static Coords? PostCodeToLongLat(string postcode, string countryCodeWithin = null)
        {
            // Download the XML response from Google 
            var client = new WebClient();
            var encodedPostCode = WebUtility.UrlEncode(postcode);
            //var url = string.Format("http://maps.google.com/maps/geo?q={0}&output=xml", encodedPostCode);
            var url = "https://maps.googleapis.com/maps/api/geocode/json?components=postal_code:" + encodedPostCode.Trim() + "&sensor=false&key=AIzaSyB_Gpj7_8j5OrZKQHINxTgqU6CkrkNKgZQ";
            var jsonText = client.DownloadString(url);
            var responseList = JsonConvert.DeserializeObject<GeolocationResponse>(jsonText);
            var response = responseList?.Results?.FirstOrDefault();
            if (response == null)
                return null;
            if(countryCodeWithin != null)
            {
                var countryComponent = response.AddressComponents.FirstOrDefault(s => s.Types.Contains("country"));
                var countryname = countryComponent.ShortName;
                if (countryname != countryCodeWithin)
                    return null;
            }

            // Get the raw Long/Lat coordinates (I wish there was a nicer way.. 
            // perhaps averaging the LongLat enclosing box?) 
            var coords = response.Geometry.Location;

            return new Coords
            {
                Longitude = coords.Lng,
                Latitude = coords.Lat
            };
        }

        public static double DistanceTo(this Coords from, Coords to, Units units)
        {
            // Haversine Formula... 
            var dLat1InRad = from.Latitude * (Math.PI / 180.0);
            var dLong1InRad = from.Longitude * (Math.PI / 180.0);
            var dLat2InRad = to.Latitude * (Math.PI / 180.0);
            var dLong2InRad = to.Longitude * (Math.PI / 180.0);

            var dLongitude = dLong2InRad - dLong1InRad;
            var dLatitude = dLat2InRad - dLat1InRad;

            // Intermediate result a. 
            var a = Math.Pow(Math.Sin(dLatitude / 2.0), 2.0) +
                    Math.Cos(dLat1InRad) * Math.Cos(dLat2InRad) *
                    Math.Pow(Math.Sin(dLongitude / 2.0), 2.0);

            // Intermediate result c (great circle distance in Radians). 
            var c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1.0 - a));

            // Unit of measurement 
            var radius = 6371;
            if (units == Units.Miles) radius = 3959;

            return radius * c;
        }
    }
}
