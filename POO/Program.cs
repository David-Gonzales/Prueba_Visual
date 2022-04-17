using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            /**
                Persona per = new Persona();
                Persona per2 = new Persona(false);
                Persona persona = new Persona() { Nombres = "José", Apellidos = "Gonzales" };
                Persona trab = new Persona() { TieneTrabajo = true };
                Persona x = new Persona() { FechaNacimiento = new DateTime(1998, 4, 25) };

                per.Nombres = "David";
                per.Apellidos = "Bocanegra";
                per.FechaNacimiento = new DateTime(2000,1,1);

                Console.Write(per.NombreCompleto + " tiene " + per.Edad + " años\n");
            **/

            List<Animal> animales = new List<Animal>();
            int rpta;
            do
            {
                animales.Add(CrearAnimal());
                rpta = LeerRespuesta();
            } while (rpta == 1);

            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal.Especie + " se traslada " + animal.FormaTraslado);
            }

            Console.ReadLine();
        }

        private static int LeerRespuesta()
        {
            int rpta;

            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("¿Desea continuar?");
            rpta = MisFunciones.LeerEntero("¿Desea Continuar?", 1, 2, "Respuesta no válida");
            return rpta;
        }

        private static Animal CrearAnimal()
        {
            int tipo;
            Console.WriteLine("1: Gato");
            Console.WriteLine("2: Pez");
            Console.WriteLine("3: Gaviota");

            tipo = MisFunciones.LeerEntero("Elija el animal: ", 1, 3, "Respuesta no válida");
            return CrearInstancia(tipo);
        }

        private static Animal CrearInstancia(int tipo)
        {
            Animal animal = null;
            switch(tipo)
            {
                case 1: animal = new Gato();
                    break;
                case 2: animal = new Pez();
                    break;
                default: animal = new Gaviota();
                    break;
            }
            return animal;
        }
    }
}
