using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uszoverseny2
{
    public class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public string OrszagNev { get; private set; }
        public string ZaszloNev { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        private static int sorSzam;

        public Versenyzo(string nev, string orszagNev, string zaszloNev)
        {
            this.Nev = nev;
            this.OrszagNev = orszagNev;
            this.ZaszloNev = zaszloNev;
            sorSzam++;
            this.Rajtszam = (sorSzam < 10) ? ("0" + sorSzam) : sorSzam.ToString();
        }

        public override string ToString()
        {
            return $"{Nev}";
        }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }
    }
}
