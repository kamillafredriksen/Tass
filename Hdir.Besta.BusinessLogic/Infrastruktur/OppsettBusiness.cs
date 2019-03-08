
using Hdir.Tass.BusinessLogic.Implementasjon;
using Hdir.Tass.Fasade.Infrastruktur;
using Hdir.Tass._DataAccess.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hdir.Tass.BusinessLogic.Infrastruktur
{
    public static class OppsettBusiness
    {
        public static void SettOppServicer(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient<IBrukerService, BrukerService>();

            serviceCollection.Configure<BrukerKonfig>(opt => configuration.GetSection("Bruker").Bind(opt));

            serviceCollection.SettOppDataAccess(configuration);
            serviceCollection.SettOppFasader(configuration);
        }
    }
}
