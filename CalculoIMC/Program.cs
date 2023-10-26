using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMC PRO CALCULATOR XTREME");

            // Solicita as informações
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            decimal peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            // Faz o calculo
            decimal imc = peso / (altura * altura);

            // Limpa a tela
            Console.Clear();

            // Mostra os resultados na tela
            Console.WriteLine(
                nome + " com sua altura de " + altura + " e peso de " + peso
            );

            Console.WriteLine("Seu IMC é de: " + imc.ToString("N2"));

            // Espera para fechar
            Console.ReadKey();
        }
    }
}
