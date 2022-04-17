using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class MisFunciones
    {
        public static int LeerEntero(string msg, int min, int max, string error)
        {
            int numero;

            do
            {
                Console.WriteLine(msg);
                numero = Int32.Parse(Console.ReadLine());
                if (numero < min || numero > max)
                {
                    Console.WriteLine(error);
                }
            }while (numero < min || numero > max);

            return numero;
        }

        public static string LeerOpcion(string msg, int min, int max)
        {
            string opcion;

            do
            {
                Console.WriteLine(msg);
                opcion = Console.ReadLine();
            } while ();
            return opcion;
        }
    }
}
