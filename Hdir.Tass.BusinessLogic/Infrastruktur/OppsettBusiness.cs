using Hdir.Tass._DataAccess.Infrastruktur;
using Hdir.Tass.BusinessLogic.Felles;
using Hdir.Tass.BusinessLogic.Felles.Tilgang;
using Hdir.Tass.BusinessLogic.Implementasjon;
using Hdir.Tass.Fasade.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hdir.Tass.BusinessLogic.Infrastruktur
{
    public static class OppsettBusiness
    {
        public static void SettOppServicer(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient<IBruker, Bruker>();

            serviceCollection.Configure<BrukerKonfig>(opt => configuration.GetSection("Bruker").Bind(opt));

            serviceCollection.SettOppDataAccess(configuration);
            serviceCollection.SettOppFasader(configuration);
        }
    }
}
