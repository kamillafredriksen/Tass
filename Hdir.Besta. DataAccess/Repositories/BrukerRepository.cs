using System;
using System.Collections.Generic;
using System.Text;
using Hdir.Besta._DataAccess.Repositories.Interfaces;

namespace Hdir.Besta._DataAccess.Repositories
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
