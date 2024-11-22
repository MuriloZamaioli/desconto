using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_na_compra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 0;
            int valorDesconto = 0;
            bool flag = false;

            try
            {
                while (!flag)
                {
                    //Solicita o valor da compra
                    Console.Write("Digite o valor da compra ou 'S' para sair: ");
                    string inputCompra = Console.ReadLine();

                    //Verifica se o usúario quer sair
                    if (inputCompra.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {
                        //Converte o valor da compra para double
                        valorCompra = double.Parse(inputCompra);
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }


                //Resetando a variável para a próxima entrada
                flag = false;

                while (!flag)
                {
                    //Solicita a porcentagem de desconto
                    Console.Write("Digite a porcentagem de desconto ou 'S' para sair: ");
                    string inputDesconto = Console.ReadLine();

                    //Verifica se o usúario quer sair
                    if (inputDesconto.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {
                        //Converte a porcentagem de desconto para int
                        valorDesconto = int.Parse(inputDesconto);

                        //Verifica se o desconto está entre 0 e 100
                        if (valorDesconto < 0 || valorDesconto > 100)
                        {
                            Console.WriteLine("Erro: a porcentagem de desconto deve estar entre 0 e 100");
                            continue;
                        }
                        flag = true;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }

                    //Calcula o valor final com desconto
                    double valorFinal = valorCompra - (valorCompra * (valorDesconto / 100.0));
                    Console.WriteLine($"Valor final com desconto: {valorFinal:C}");
                }
            }
            finally
            {
                Console.WriteLine("Operação concluída");
                Console.ReadKey();
            }












        }
    }
}
