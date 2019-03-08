using Hdir.Tass.BusinessLogic.Felles.Bruker;

namespace Hdir.Tass.BusinessLogic.Implementasjon
{
    public interface IBrukerService
    {
        BrukerDto GetBruker(string username);
    }
}

