using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa que solicite quatro números 
                e ao final mostre a média. 
            */

            // 1 - Solicitar os numero
            // 2 - Calcular a média
            // 3 - Mostrar o resultado

            Console.WriteLine("MEDIA STORM 3000");

            Console.Write("Digite o primeiro numero: ");
            decimal numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            decimal numero_dois = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            decimal numero_tres = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o quarto numero: ");
            decimal numero_quatro = Convert.ToDecimal(Console.ReadLine());

            // Faz o calculo da média
            decimal resultado_media = (
                numero_um + numero_dois + numero_tres + numero_quatro
            ) / 4;

            // decimal[] numeros = { numero_um, numero_dois, numero_tres, numero_quatro };
            // resultado_media = numeros.Average();

            // Mostra o resultado

            Console.WriteLine("A média dos numeros é: " + resultado_media);

            // Faz o programa esperar antes de fechar
            Console.ReadKey();
        }
    }
}
