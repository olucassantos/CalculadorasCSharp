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

            // Mostra uma mensagem de acordo com o numero do IMC

            if (imc < 18.5m)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc >= 18.5m && imc < 24.9m)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 29.9m)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc < 34.9m)
            {
                Console.WriteLine("Obeso I");
            }
            else if (imc >= 35 && imc < 39.9m)
            {
                Console.WriteLine("Obeso II");
            }
            else
            {
                Console.WriteLine("Obeso III ou Mórbido");
            }


            // Espera para fechar
            Console.ReadKey();
        }
    }
}
