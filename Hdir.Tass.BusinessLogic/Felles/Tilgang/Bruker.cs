using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hdir.Tass.BusinessLogic.Felles.Tilgang
{
    class Bruker : IBruker
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public Bruker(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public AvsenderRolle Rolle => throw new NotImplementedException();
    }
}
