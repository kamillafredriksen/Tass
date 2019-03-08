using Hdir.Besta.BusinessLogic.Felles.Bruker;

namespace Hdir.Besta.Api.ViewModels
{
    public class Bruker
    {
        public string[] Gruppe { get; set; }

        public string Navn { get; set; }

        public string Epost { get; set; }

        public bool Aktiv { get; set; }

        public Bruker MapTilView(BrukerDto bruker)
        {
            return new Bruker
            {
                Aktiv = bruker.Aktiv,
                Epost = bruker.Epost,
                Gruppe = bruker.Gruppe,
                Navn = bruker.Navn
            };
        }
    }
}
