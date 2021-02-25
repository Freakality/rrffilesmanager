// Preview Handlers Revisted
// Bradley Smith - 2010/09/17, updated 2013/10/14

using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Win32;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;

namespace RRFFilesManager
{

    public class PdfAxHost : AxHost
    {
        public PdfAxHost() :
            base("ca8a9780-280d-11cf-a24d-444553540000")
        { }

        object _ocx;
        protected override void AttachInterfaces() { _ocx = base.GetOcx(); }

        public void LoadFile(string fileName)
        {
            if (_ocx == null)
                AttachInterfaces();
            _ocx.GetType().InvokeMember(
                "LoadFile", BindingFlags.InvokeMethod, null,
                _ocx, new object[] { fileName });
        }
    }

}