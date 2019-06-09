using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiguitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int.TryParse(Console.ReadLine(), out int nu1);//lee y lo convierte y lo guarda en la variable nu1
            Console.WriteLine("Ingrese el segundo numero");
            int.TryParse(Console.ReadLine(), out int nu2);//lee y lo convierte y lo guarda en la variable nu2
            Console.WriteLine("Ingrese el segundo numero");
            int.TryParse(Console.ReadLine(), out int nu3);//lee y lo convierte y lo guarda en la variable nu3
            int resp= comparar(nu1, nu2, nu3);
            Console.WriteLine("El maximo es: " + resp);



        }

        public static int comparar(int nu1, int nu2, int nu3) {
            int max ;
            if ((nu1 > nu2) && (nu1 > nu3))
            {
                max = nu1;
            }
            else if ((nu2 > nu1) && (nu2 > nu3))
            {
                max = nu2;
            }
            else { max = nu3; }

            return max;
        }
    }
}
