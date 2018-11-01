using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_For_Honor
{
    class Ellenfel
    {
        private string nev;
        private int elet;
        private int max_elet;
        private int min_sebzes;
        private int max_sebzes;
        private int vedelem;
        private int szint;
        private bool el;
        private int adott_tapsztalat;
        private Mob_Loot kapott_loot;
        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        public int Elet
        {
            get
            {
                return elet;
            }

            set
            {
                elet = value;
            }
        }

        public int Min_sebzes
        {
            get
            {
                return min_sebzes;
            }

            set
            {
                min_sebzes = value;
            }
        }

        public int Max_sebzes
        {
            get
            {
                return max_sebzes;
            }

            set
            {
                max_sebzes = value;
            }
        }

        public int Vedelem
        {
            get
            {
                return vedelem;
            }

            set
            {
                vedelem = value;
            }
        }

        public bool El
        {
            get
            {
                return el;
            }

            set
            {
                el = value;
            }
        }

        internal Mob_Loot Kapott_loot
        {
            get
            {
                return kapott_loot;
            }

            set
            {
                kapott_loot = value;
            }
        }

        public int Max_elet
        {
            get
            {
                return max_elet;
            }

            set
            {
                max_elet = value;
            }
        }

        public Ellenfel() { }

        public Ellenfel(string nev,
         int elet,
         int max_elet,
         int min_sebzes,
         int max_sebzes,
         int vedelem,
         int szint,
         bool el,
          int adott_tapsztalat,
          Mob_Loot kapott_loot)
        {

            this.nev = nev;
            this.elet = elet;
            this.max_elet = max_elet;
            this.min_sebzes = min_sebzes;
            this.max_sebzes = max_sebzes;
            this.vedelem = vedelem;
            this.szint = szint;
            this.el = el;
            this.adott_tapsztalat = adott_tapsztalat;
            this.kapott_loot = kapott_loot;
        }
    }
}
