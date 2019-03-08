
using Hdir.Besta.BusinessLogic.Implementasjon;
using Hdir.Besta.Fasade.Infrastruktur;
using Hdir.Besta.Felles.Infrastruktur;
using Hdir.Besta._DataAccess.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hdir.Besta.BusinessLogic.Infrastruktur
{
    public static class OppsettBusiness
    {
        public static void SettOppServicer(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient<IBrukerService, BrukerService>();

            serviceCollection.Configure<BrukerKonfig>(opt => configuration.GetSection("Bruker").Bind(opt));

            serviceCollection.SettOppFelles(configuration);
            serviceCollection.SettOppDataAccess(configuration);
            serviceCollection.SettOppFasader(configuration);
        }
    }
}
