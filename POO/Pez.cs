using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Pez : Animal
    {
        public Pez()
        {
            this.Especie = "Pez";
        }
        public override string FormaTraslado
        {
            get
            { return "Nadando"; }
        }
    }
}
