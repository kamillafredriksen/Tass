using Hdir.Tass.Api.Enum;
using System;

namespace Hdir.Tass.Api.ViewModels
{
    public class Søknad
    {
        public string Organisasjosnummer { get; set; }

        public string[] Personnummer { get; set; }

        public string[]  Grupper { get; set; }

        public Søknadstype Type { get; set; }

        public DateTime Fra { get; set; }

        public DateTime? Til { get; set; }
    }
}
