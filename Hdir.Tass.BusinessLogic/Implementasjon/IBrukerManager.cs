using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hdir.Tass.BusinessLogic.Implementasjon
{
    public interface IBrukerManager
    {
        FileStreamResult FinnBruker(long brukerId);
    }
}

