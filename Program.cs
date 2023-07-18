using System;
using System.Drawing;

namespace ConsoleApp
{
    class Program
    {
        static PagamentoBoleto pBoleto1 = new();
        static void Main(string[] args)
        {
            // Console.Clear();

            AppPresetation();
            UserInfo();

            pBoleto1.Pagar();
        }


        static void AppPresetation()
        {
            string appName = "Pagamento console";
            string appVersion = " 1.0.0";
            string appAuthor = "Victor Daniel Lander";

            ConsoleCollorPrinter($"{appName}, Versão {appVersion}, feito por {appAuthor}", ConsoleColor.Magenta);
        }

        static void UserInfo()
        {
            Console.WriteLine("Digite seu nome");

            string userName = "";
            userName += Console.ReadLine();

            Console.WriteLine("Seu nome é {0}", userName ?? "Desconhecido");
        }

        static void ConsoleCollorPrinter(string text, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine($"{text}");
            Console.ResetColor();

        }


    }

}