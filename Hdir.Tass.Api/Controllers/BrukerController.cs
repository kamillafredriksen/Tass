using System;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using Hdir.Tass.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hdir.Tass.Api.Controllers
{
    /// <summary>
    ///  Konstruktør
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BrukerController : ControllerBase
    {
        /*private readonly IBrukerManager _brukerManager;

        /// <summary>
        ///  Konstruktør
        /// </summary>
        public BrukerController(IBrukerManager brukerManager)
        {
            _brukerManager = brukerManager;
        }*/

        /// <summary>
        ///  Henter informasjon av innlogget bruker
        /// </summary>
        [HttpGet]
        public ActionResult Get()
        {
            var identity = HentIdentitet();
            return Ok(identity);
        }

        private Bruker HentIdentitet()
        {
            using (var context = new PrincipalContext(ContextType.Domain, "utvikling"))
            {
                var username = User.Identity.Name;
                var user = UserPrincipal.FindByIdentity(context, username);
                if (user != null)
                {
                    return new Bruker
                    {
                        Aktiv = user.AccountExpirationDate > DateTime.Now,
                        Gruppe = user.GetGroups().Select(x => x.Name).ToArray(),
                        Navn = $"{user.GivenName} {user.Surname}",
                        Epost = user.EmailAddress
                    };
                }
                return new Bruker();
            }
        }
    }
}