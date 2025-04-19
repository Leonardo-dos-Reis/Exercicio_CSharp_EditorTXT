using System;
using System.Buffers;

namespace TextEitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("0 - Para sair do programa");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0 : System.Environment.Exit(0); break;
                // case 1 : Abrir(); break;
                // case 2 : Editar(); break;
                default: Menu(); break;
            }
        }
    }
}