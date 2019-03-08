using Hdir.Tass.BusinessLogic.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hdir.Tass.Api.Infrastruktur
{
    public static class OppsettApi
    {
        public static void SettOppService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.SettOppServicer(configuration);
        }
    }
}
