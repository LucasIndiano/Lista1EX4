using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, soma;

            Console.WriteLine("Digite o numero A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero X: ");
            x = int.Parse(Console.ReadLine());

            if (x > 5 ) { 
            soma = (a + b) * x;
                Console.WriteLine(soma);      
            }
            else
            {
                soma = (a - b) * x;
                Console.WriteLine(soma);
            }

            Console.ReadKey();

        }
    }
}
