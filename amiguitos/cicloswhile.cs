using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiguitos
{
    class cicloswhile
    {
        private static void Main(String[] args) {
            Console.WriteLine("ingrese el n");
            int.TryParse(Console.ReadLine(), out int n);
            naturales(n);
        }

        public static void naturales(int n) {
            int i = 1;
            while (i >= n) {
                Console.WriteLine(i++);
                //i++;
            }

        }
        //int i = 1;
        //while (i<=n) {
        //Console.WriteLine(n--);
        //i++;


    }
}
