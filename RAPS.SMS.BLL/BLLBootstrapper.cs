using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using RAPS.SMS.DLL.DLL.Repositories;

namespace RAPS.SMS.BLL
{
    public class BLLBootstrapper
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // your current code goes here
            // ...
            services.AddScoped<IPeopleService, PeopleService>();

        }
    }
}
