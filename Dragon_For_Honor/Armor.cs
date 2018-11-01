using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_For_Honor
{
    class Armor
    {
        private int vedelmi_ero;
        private string nev;

        public int Vedelmi_ero
        {
            get
            {
                return vedelmi_ero;
            }

            set
            {
                vedelmi_ero = value;
            }
        }

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

        public Armor(int vedelmi_ero, string nev)
        {
            this.vedelmi_ero = vedelmi_ero;
            this.nev = nev;
        }
        public Armor()
        {

        }
    }
}
