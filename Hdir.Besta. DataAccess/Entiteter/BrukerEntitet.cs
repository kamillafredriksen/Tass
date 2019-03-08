using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hdir.Besta._DataAccess.Entiteter
{
    public class BrukerEntitet
    {
        [Key]
        public long Id { get; set; }

        public string Gruppe { get; set; }

        public string Navn { get; set; }

        public bool Aktiv { get; set; }
    }
}
