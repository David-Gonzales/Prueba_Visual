using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Gato : Animal
    {
        public Gato()
        {
            this.Especie = "Gato";
        }
        public override string FormaTraslado
        {
            get 
            {
                return "caminando";
            }
        }

        
    }
}
