using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NguyenQuocDat_SE1608_A01.Application.Contracts.Logics;
using NguyenQuocDat_SE1608_A01.Application.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Application
{
    public static class Injection
    {
        public static IServiceCollection RegistserApplicationServices(this IServiceCollection service, IConfiguration config)
        {
            service.AddScoped<ICustomerRepository, CustomerRepository>();
            return service;
        }
    }
}
