using System;
using System.Drawing;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            AppPresetation();
            UserInfo();
            NumberGuesser();
        }


        static void AppPresetation()
        {
            string appName = "Number Guesser";
            string appVersion = " 1.0.0";
            string appAuthor = "Victor Daniel Lander";

            ConsoleCollorPrinter($"{appName}, Versão {appVersion}, feito por {appAuthor}", ConsoleColor.Magenta);
        }

        static void UserInfo()
        {
            Console.WriteLine("Digite seu nome");

            string userName = Console.ReadLine();

            if (!string.IsNullOrEmpty(userName))
                Console.WriteLine("Seu nome e {0}", userName);
        }
        static void NumberGuesser()
        {
            while (true)
            {
                // se for reutilizado mais vezes
                //Random random = new Random();
                //   int correctNumber = random.Next(1, 10);

                int correctNumber = new Random().Next(1, 10);
                int guessNumber = 0;

                Console.WriteLine("Tente adivinhar o numero");

                while (correctNumber != guessNumber)
                {
                    //guessNumber = Convert.ToInt32(Console.ReadLine());
                    // guessNumber = Int32.TryParse(Console.ReadLine());
                    bool isValid = int.TryParse(Console.ReadLine(), out guessNumber);
                    if (!isValid)
                    {
                        ConsoleCollorPrinter("Por favor digite apenas numeros", ConsoleColor.Red);
                        continue;// continue dentro do while volta para o inicio do mesmo
                    }


                    if (correctNumber != guessNumber)
                    {
                        ConsoleCollorPrinter("Numero errado,tente novamente", ConsoleColor.Red);
                    }
                }
                ConsoleCollorPrinter("Parabens voce acertou o numero", ConsoleColor.Green);

                Console.WriteLine("Quer jogar de novo ? , [Y ou N]");

                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "Y")
                    continue;
                else if (resposta == "N")
                    return;
                else
                    return;

            }
        }
        static void ConsoleCollorPrinter(string text, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine($"{text}");
            Console.ResetColor();

        }

    }
}