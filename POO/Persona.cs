using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneTrabajo { get; set; }

        public Persona() { } //Singleton

        public Persona(bool tieneTrabajo)
        {
            this.TieneTrabajo = tieneTrabajo;
        }
        public Persona(Object [] datos)
        {
            this.Nombres = datos[0].ToString();
            this.Apellidos = datos[1].ToString();
        }

        public string NombreCompleto
        {
            get { return this.Nombres + " " + this.Apellidos; }
        }        
        public int Edad
        {
            get { return DateTime.Now.Year - this.FechaNacimiento.Year; }
        }

        public bool EsMayor
        {
            get
            {
                if(this.Edad < 18)
                    return false;
                else
                    return true;
            }
        }
    }
}
