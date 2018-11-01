using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_For_Honor
{
    class Fegyver
    {
        private int minimum_sebzes;
        private int maximum_sebzes;
        private string nev;

        public int Minimum_sebzes
        {
            get
            {
                return minimum_sebzes;
            }

            set
            {
                minimum_sebzes = value;
            }
        }

        public int Maximum_sebzes
        {
            get
            {
                return maximum_sebzes;
            }

            set
            {
                maximum_sebzes = value;
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

        public Fegyver(int minimum_sebzes, int maximum_sebzes, string nev)
        {
            this.minimum_sebzes = minimum_sebzes;
            this.maximum_sebzes = maximum_sebzes;
            this.nev = nev;
        }
        public Fegyver()
        {

        }
    }
}
