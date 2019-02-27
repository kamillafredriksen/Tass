using Hdir.Tass._DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hdir.Tass._DataAccess.Repositories
{
    class BrukerRepository : IBruker
    {
        private readonly MainDbContext _dbContext;

        public BrukerRepository(MainDbContext context)
        {
            _dbContext = context;
        }
        public string FinnGruppeTilBruker(string personId)
        {
            return personId;
        }
    }
}
