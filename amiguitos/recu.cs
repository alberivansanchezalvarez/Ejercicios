using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiguitos
{
    class recu
    {
        private static void Main(string[] args) {
            Console.WriteLine("Ingrese el numero");
            int.TryParse(Console.ReadLine(), out int nu1);
            Console.WriteLine(respuesta(nu1));
        }

        public static int respuesta (int nu1) {
            int cubo=1;
             

            return respuesta(cubo= cubo*nu1);
        }
    }
}
