using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Mapper
{
    public static class Registration
    {
            public static void AddCustomMapper(this IServiceCollection services)
            {   
                services.AddSingleton<IMapper,AutoMapper.Mapper>();
            
            }
    }
}
