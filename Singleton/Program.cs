using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPro A1 = SingletonPro.ObtenerInstancia();
            SingletonPro A2 = SingletonPro.ObtenerInstancia();

            string resultado;

            if (A1 == A2)
            {
                resultado = "Ambas instancias son la misma.";
            }
            else
            {
                resultado = "Son diferentes instancias.";
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
