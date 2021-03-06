﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Hdir.Besta._DataAccess.Repositories;
using Hdir.Besta._DataAccess.Repositories.Interfaces;

namespace Hdir.Besta._DataAccess.Infrastruktur
{
    public static class OppsettDataAccess
    {
        public static void SettOppDataAccess(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var vedtakConnection = configuration.GetConnectionString("TassDb");

            serviceCollection.AddTransient<IBruker, BrukerRepository>();

            serviceCollection.AddDbContext<MainDbContext>(options => options.UseSqlServer(vedtakConnection));
        }
    }
}
