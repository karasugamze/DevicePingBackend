using Business.Abstract;
using Business.Abstract.Services;
using Business.Repositories;
using Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class ServiceRegistration
    {
        public static void addBusinessServices(this IServiceCollection services){
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<IPingServices, PingService>();
        }

    }
}
