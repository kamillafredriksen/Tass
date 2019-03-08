using Hdir.Tass.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Hdir.Tass.Api.Controllers
{
    /// <summary>
    ///  Søknadsendepunkter
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SøknadController : ControllerBase
    {

        public List<Søknad> AlleLister()
        {

            var søknader = new List<Søknad>
            {
                new Søknad
                {
                    Fra = DateTime.Now,
                    Grupper = new string[] { "GRP1", "GRP2"},
                    Organisasjosnummer = "123456789",
                    Personnummer = new string[] { "15789845850", "15789845851" },
                    Til = DateTime.Now,
                    Type = Enum.Søknadstype.Import
                }
            };

            return søknader;
        }

        /// <summary>
        ///  Henter informasjon av innlogget bruker
        /// </summary>
        [HttpGet]
        public ActionResult Get()
        {
            //hentSøknader
            return Ok(AlleLister());
        }


        /// <summary>
        ///  Oppretter en ny søknad
        /// </summary>
        [HttpPost]
        public ActionResult Post([FromBody] Søknad søknad)
        {
            return Ok();
        }

    }
}