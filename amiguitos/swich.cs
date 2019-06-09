using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiguitos
{
    class swich
    {
       


    private static void Main(String[] args) {
            int A, nu2;
            char operacion;

            Console.WriteLine("ingrese el primer numero");
            int.TryParse(Console.ReadLine(), out A);

            Console.WriteLine("ingrese el segundo numero");
            int.TryParse(Console.ReadLine(), out nu2);

            Console.WriteLine("que operacion quiere realizar + - / * ");            
            char.TryParse(Console.ReadLine(), out operacion);

            float resp=calculadora(A,nu2, operacion);

            Console.WriteLine("la respuesta es: " + resp);

        }

        public static float calculadora (int A, int B, char ope)
        {
            float resp=0;
            switch (ope) {
                case '+': 
                    resp = A + B;
                    break;
                case '-':
                    resp = A - B;
                    break;
                case '*':
                    resp = A * B;
                    break;
                case '/':
                    resp = A / B;
                    break;
                default:
                    Console.WriteLine("No se pudo realizar la operación");
                    break;
                        
            }
            return resp;

        }
            

    }
}
