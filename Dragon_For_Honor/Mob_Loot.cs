using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_For_Honor
{
    class Mob_Loot
    {
        private Fegyver dobott_fegyver;
        private bool van_e_fegyver;
        private Armor dobott_armor;
        private bool van_e_armor;
        internal Fegyver Dobott_fegyver
        {
            get
            {
                return dobott_fegyver;
            }

            set
            {
                dobott_fegyver = value;
            }
        }

        internal Armor Dobott_armor
        {
            get
            {
                return dobott_armor;
            }

            set
            {
                dobott_armor = value;
            }
        }

        public bool Van_e_fegyver
        {
            get
            {
                return van_e_fegyver;
            }

            set
            {
                van_e_fegyver = value;
            }
        }

        public bool Van_e_armor
        {
            get
            {
                return van_e_armor;
            }

            set
            {
                van_e_armor = value;
            }
        }

        public Mob_Loot(Fegyver dobott_fegyver, Armor dobott_armor)
        {
            this.Dobott_fegyver = dobott_fegyver;
            this.Dobott_armor = dobott_armor;

        }
        public Mob_Loot() { }
    }
}
