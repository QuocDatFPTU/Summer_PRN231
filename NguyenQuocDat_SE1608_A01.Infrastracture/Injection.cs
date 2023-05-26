using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NguyenQuocDat_SE1608_A01.Application.Contracts.Data;
using NguyenQuocDat_SE1608_A01.Application.Data;
using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Infrastracture
{
    public static class Injection
    {
        public static IServiceCollection RegisterInfrastructerServices(this IServiceCollection services, IConfiguration configuration)
        {
            {
                services.AddDbContext<FUFlowerBouquetManagementContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("FuFlowerSystem"));
                });
                services.AddScoped<IFUFlowerBouquetManagementContext>(optiont => optiont.GetService<FUFlowerBouquetManagementContext>());
                return services;
            }
        }
    }
}
