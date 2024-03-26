using System;
using System.Drawing;
using Trabalho1;

bool entrada = true;

do
{
    try
    {
        Console.WriteLine("\nEscolha uma opção:\n0 para sair \n1 para somar números\n2 para converter de metros para milímetros\n3 para fatorar um número de 1 a 10");
        int opcao = int.Parse(Console.ReadLine());
        int n; int m; float j;

        switch (opcao)
        {
            case 0:
                entrada = false;
                break;
            case 1:
                Console.WriteLine("Digite um número: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Precisa ser um número");
                }
                Console.WriteLine("Digite um número: ");
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Precisa ser um número");
                }
                Console.WriteLine($"{n} + {m} = {Somatorio.Soma(n, m)}");
                break;
            case 2:
                Console.WriteLine("Quantos metros você tem?");
                while (!float.TryParse(Console.ReadLine(), out j))
                {
                    Console.WriteLine("Precisa ser um número!");
                }
                Console.WriteLine($"{j} metros em milímetros é: {ConverteMparaMM.Conversor(j)}mm");
                break;
            case 3:
                Console.WriteLine("Qual número você quer fatorar?");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10)
                {
                    Console.WriteLine("O número inserido deve estar entre 1 e 10!");
                }
                Console.WriteLine($"{n}! = {CalculoFatorial.Fatorial(n)}");
                break;
            default:
                Console.WriteLine("Não entendi, tente outra vez"); break;

        }

    }
    catch (FormatException)
    {
        Console.WriteLine("É necessário digitar um número inteiro dentre as opções dadas");
    }

} while (entrada);
