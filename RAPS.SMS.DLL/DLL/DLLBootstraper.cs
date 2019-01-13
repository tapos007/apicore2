using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RAPS.SMS.DLL.DLL.Models;
using RAPS.SMS.DLL.DLL.Repositories;

namespace RAPS.SMS.DLL.DLL
{
   public  class DLLBootstraper
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // your current code goes here
            // ...

            
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            
        }
    }
}
