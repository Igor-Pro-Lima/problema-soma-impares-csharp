using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Ler dois numeros inteiros e mostrar a soma dos ímpares entre eles.

namespace problema_soma_impares {
    internal class Program {
        static void Main(string[] args) {

            int x, y, troca, soma;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            ///Toda soma acumulada deve começar com zero.
            if (x > y) {
                troca = x;
                x = y;
                y = troca;
            }

            soma = 0;
            for (int i = x+1; i < y; i++) { 
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);

        }
    }
}
