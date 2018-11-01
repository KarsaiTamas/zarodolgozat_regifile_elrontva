using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_For_Honor
{
    class Jatekos
    {
        private string nev;
        private int elet_ero;
        private int max_elet_ero;
        private int szint;
        private int tapasztalat;
        private Fegyver felvett_fegyver;
        private Armor felvett_pancel;
         
        private bool el;
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

        public int Elet_ero
        {
            get
            {
                return elet_ero;
            }

            set
            {
                elet_ero = value;
            }
        }

        public int Szint
        {
            get
            {
                return szint;
            }

            set
            {
                szint = value;
            }
        }

        public int Tapasztalat
        {
            get
            {
                return tapasztalat;
            }

            set
            {
                tapasztalat = value;
            }
        }

        internal Fegyver Felvett_fegyver
        {
            get
            {
                return felvett_fegyver;
            }

            set
            {
                felvett_fegyver = value;
            }
        }

        internal Armor Felvett_pancel
        {
            get
            {
                return felvett_pancel;
            }

            set
            {
                felvett_pancel = value;
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

        public int Max_Elet_Ero
        {
            get
            {
                return max_elet_ero;
            }

            set
            {
                max_elet_ero = value;
            }
        }

        public Jatekos() { }
        public Jatekos(
            string nev,
            int elet_ero,
            int szint,
            int tapasztalat,
            int max_elet_ero,
            Fegyver felvett_fegyver,
            Armor felvett_pancel,
            bool el   )
        {
            this.nev = nev;
            this.elet_ero = elet_ero;
            this.max_elet_ero = max_elet_ero;
            this.szint = szint;
            this.tapasztalat = tapasztalat;
            this.felvett_fegyver = felvett_fegyver;
            this.felvett_pancel = felvett_pancel;
            this.El = el;
             
        }
    }
}
