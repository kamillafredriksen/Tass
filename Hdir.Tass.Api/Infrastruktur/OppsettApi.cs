using Hdir.Tass.BusinessLogic.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hdir.Tass.Api.Infrastruktur
{
    public static class OppsettApi
    {
        public static void SettOppApi(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.SettOppServicer(configuration);
        }
    }
}
