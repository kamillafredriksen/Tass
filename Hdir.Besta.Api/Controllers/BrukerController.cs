using Hdir.Tass.BusinessLogic.Implementasjon;
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
        private readonly IBrukerService _brukerService;
        public BrukerController(IBrukerService brukerService)
        {
            _brukerService = brukerService;
        }

        /// <summary>
        ///  Henter informasjon av innlogget bruker
        /// </summary>
        
        [HttpGet]
        public ActionResult Get()
        {
            var bruker = _brukerService.GetBruker(User.Identity.Name);
            return Ok(bruker);
        }
    }
}