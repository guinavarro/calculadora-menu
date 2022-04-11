using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem-vindo ao CALC, selecione uma das opções abaixo");
                Console.WriteLine("\n1 - SOMA\n2 - SUBTRAÇÃO\n3 - DIVISÃO\n4 - MULTIPLICAÇÃO\n5 - POTÊNCIA\n6 - RAIZ\n7 - SAIR");

                // string > int > menu
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                }
                Console.Clear();
            }

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado da soma de {a} e {b} é de: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu...");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado da subtração de {a} e {b} é de: {resultado}");
            Console.WriteLine("\nDigite ENTER para retornar ao menu...");
            Console.ReadLine();

        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primeiro número:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado da divisão de {a} por {b} é de: {resultado}");
            Console.WriteLine("\nDigite ENTER para sair do programa...");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação de {a} por {b} é de: {resultado}");
            Console.WriteLine("\nDigite ENTER para retornar ao menu...");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Exponenciação");
            Console.WriteLine("Digite o número da base:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            double b = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"A exponenciação de {a}^{b} é de: {resultado}");
            Console.WriteLine("\nPressione ENTER para retornar ao Menu...");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Radiciação:");
            Console.WriteLine("Digite o número para sabermos sua raiz quadrada");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz quadrada de {a} é de: {resultado}");
            Console.WriteLine("\nDigite ENTER para retornar ao MENU...");
            Console.ReadLine();
        }
    }
}
