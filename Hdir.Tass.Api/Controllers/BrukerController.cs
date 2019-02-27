using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hdir.Tass.BusinessLogic.Implementasjon;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public ActionResult Get()
        {
            var identity = User.Identity;
            var s = User.Identities.FirstOrDefault().Claims.FirstOrDefault();

            var b = User.Claims;

            var a = User.Claims.Where(x => x.Type.Equals("groups")).ToList();


            var u = User.Claims.Select(c => c.Value);
            return Ok(a);
        }
    }
}