using System;
using System.Drawing;
//using TesteNamespace.x;

namespace ConsoleApp
{
    class Program
    {
        static TesteNamespace.x.Teste teste1;

        static void Main(string[] args)
        {
            Console.Clear();

            AppPresetation();

            teste1 = new TesteNamespace.x.Teste("Lander"); // Inicialização do objeto teste1
            teste1.Metodo();

            // teste1.nome = "Jose";
            // teste1.Metodo();
        }


        static void AppPresetation()
        {
            string appName = "Multiplos arquivos";
            string appVersion = " 1.0.0";
            string appAuthor = "Victor Daniel Lander";

            ConsoleCollorPrinter($"{appName}, Versão {appVersion}, feito por {appAuthor}", ConsoleColor.Magenta);
        }


        static void ConsoleCollorPrinter(string text, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine($"{text}");
            Console.ResetColor();

        }

    }
}