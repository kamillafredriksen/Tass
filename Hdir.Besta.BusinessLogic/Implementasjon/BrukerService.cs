using System;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using Hdir.Besta.BusinessLogic.Felles.Bruker;

namespace Hdir.Besta.BusinessLogic.Implementasjon
{
    public class BrukerService : IBrukerService
    {

        public BrukerDto GetBruker(string username)
        {
            using (var context = new PrincipalContext(ContextType.Domain, "utvikling"))
            {
                var user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    return new BrukerDto
                    {
                        Aktiv = user.AccountExpirationDate > DateTime.Now,
                        Gruppe = user.GetGroups().Select(x => x.Name).ToArray(),
                        Navn = $"{user.GivenName} {user.Surname}",
                        Epost = user.EmailAddress
                    };
                }
                return null;
            }
        }
    }
}
