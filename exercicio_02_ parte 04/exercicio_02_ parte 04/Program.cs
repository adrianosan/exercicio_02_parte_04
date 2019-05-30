using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02__parte_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            Console.Write("Digite o primeiro número. ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número. ");
            segundoNumero = int.Parse(Console.ReadLine());


            if (primeiroNumero > segundoNumero)
            {
                Console.WriteLine("primeiro número maior");
            }

            else
            {
                Console.WriteLine("segundo número maior");
            }         
        }        
           

    }
}
