﻿using Microsoft.Extensions.DependencyInjection;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            services.AddTransient<IMatterTypeRepository, MatterTypeRepository>();
            services.AddTransient<IIntakeRepository, IntakeRepository>();
            return services;
        }
    }
}
