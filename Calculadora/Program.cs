using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Criar um script que solicite 2 numeros ao usuário
                e ao final mostre a soma dos valores.
            */

            // Define as variáveis
            decimal numero_um;
            decimal numero_dois;
            decimal resultado;

            Console.WriteLine("SOMA APP 3000");

            Console.Write("Informe o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            // Mostra o resultado da soma
            resultado = numero_um + numero_dois;

            Console.WriteLine(
                "A soma do numero " + numero_um + " e "
                + numero_dois + " é: " + resultado
            );

            // Mostra o resultado da multiplicação
            resultado = numero_um * numero_dois;

            Console.WriteLine(
                "O produto do numero " + numero_um + " e "
                + numero_dois + " é: " + resultado
            );

            // Mostra o resultado da subtração
            resultado = numero_um - numero_dois;

            Console.WriteLine(
                "O diferença do " + numero_um + " e "
                + numero_dois + " é: " + resultado
            );

            // Mostra o quociente da subtração
            resultado = numero_um / numero_dois;

            Console.WriteLine(
                "O quociente do " + numero_um + " e "
                + numero_dois + " é: " + resultado
            );

            // Faz o console aguardar antes de fechar.
            Console.ReadKey();
        }
    }
}
