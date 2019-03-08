using Hdir.Besta.BusinessLogic.Infrastruktur;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hdir.Besta.Api.Infrastruktur
{
    public static class OppsettApi
    {
        public static void SettOppService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.SettOppServicer(configuration);
        }
    }
}
