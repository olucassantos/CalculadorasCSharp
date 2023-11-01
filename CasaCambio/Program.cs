
/*
    1 - Solicitar a cotação das moedas em dolar
    2 - Solicitar o par de moedas para conversão
    3 - Solicitar o valor para conversão
    4 - Converter o valor para dolar
    5 - Converter de dolar para a moeda destino
    6 - Mostrar resultado para o cliente  
*/

using System;

namespace CasaCambio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("=CASA DE CÂMBIO PRO CONVERTER 5000=");
            Console.WriteLine("===================================");
            Console.WriteLine();

            // 1 - Solicitar a cotação das moedas em dolar
            Console.WriteLine("Por favor, insira a cotação em dolar");
            Console.WriteLine("para a conversão dos valores.");
            Console.WriteLine();

            Console.WriteLine("Quanto vale 1 euro em Dolar?");
            decimal taxa_euro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quanto vale 1 iene em Dolar?");
            decimal taxa_iene = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quanto vale 1 real em Dolar?");
            decimal taxa_real = Convert.ToDecimal(Console.ReadLine());

            // Limpar a tela
            Console.Clear();

            Console.WriteLine("===================================");
            Console.WriteLine("=CASA DE CÂMBIO PRO CONVERTER 5000=");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("1 - DOLAR: 1");
            Console.WriteLine("2 - EURO: " + taxa_euro);
            Console.WriteLine("3 - IENE: " + taxa_iene);
            Console.WriteLine("4 - REAL: " + taxa_real);
            Console.WriteLine("***************");

            // 2 - Solicitar o par de moedas para conversão
            Console.WriteLine("Qual será a moeda de origem?");
            int moeda_origem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual será a moeda de destino?");
            int moeda_destino = Convert.ToInt32(Console.ReadLine());

            // Limpa a tela
            Console.Clear();

            // 3 - Solicitar o valor para conversão

            Console.WriteLine("===================================");
            Console.WriteLine("=CASA DE CÂMBIO PRO CONVERTER 5000=");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("Qual o valor total que deseja converter?");
            decimal valor_para_converter = Convert.ToDecimal(Console.ReadLine());

            // 4 - Converter o valor para dolar

            decimal valor_dolar = 0;

            if (moeda_origem == 1)
            {
                // Moeda de origem é dolar.
                valor_dolar = valor_para_converter;
            }
            else
            {
                // Moeda de origem não é dolar.
                // Converter o valor de origem para dolar.
                if (moeda_origem == 2)
                {
                    valor_dolar = valor_para_converter * taxa_euro;
                }
                else if (moeda_origem == 3)
                {
                    valor_dolar = valor_para_converter * taxa_iene;
                }
                else if (moeda_origem == 4)
                {
                    valor_dolar = valor_para_converter * taxa_real;
                }
            }

            // 5 - Converter de dolar para a moeda destino

            decimal valor_convertido = 0;

            if (moeda_destino == 1)
            {
                valor_convertido = valor_dolar;
            }
            else if (moeda_destino == 2)
            {
                valor_convertido = valor_dolar / taxa_euro;
            }
            else if (moeda_destino == 3)
            {
                valor_convertido = valor_dolar / taxa_iene;
            }
            else if (moeda_destino == 4)
            {
                valor_convertido = valor_dolar / taxa_real;
            }

            // 6 - Mostrar resultado para o cliente
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("=CASA DE CÂMBIO PRO CONVERTER 5000=");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("1 - DOLAR: 1");
            Console.WriteLine("2 - EURO: " + taxa_euro);
            Console.WriteLine("3 - IENE: " + taxa_iene);
            Console.WriteLine("4 - REAL: " + taxa_real);
            Console.WriteLine("***************");

            Console.WriteLine("Convertendo de " + moeda_origem + " para " + moeda_destino);
            Console.WriteLine("Valor a ser convertido: " + valor_para_converter);

            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine("O valor final convertido é: " + valor_convertido.ToString("N2"));
            Console.WriteLine("*************************************************");

            // Espera
            Console.ReadKey();
        }
    }
}
