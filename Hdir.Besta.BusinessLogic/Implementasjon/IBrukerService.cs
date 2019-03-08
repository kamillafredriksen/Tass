using Hdir.Besta.BusinessLogic.Felles.Bruker;

namespace Hdir.Besta.BusinessLogic.Implementasjon
{
    public interface IBrukerService
    {
        BrukerDto GetBruker(string username);
    }
}

