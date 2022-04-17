using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Gaviota : Animal
    {
        public Gaviota()
        {
            this.Especie = "Gaviota";
        }

        public override string FormaTraslado
        {
            get
            {
                return "volando";
            }
        }
    }
}
