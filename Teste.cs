using System;
using System.Drawing;

namespace TesteNamespace
{

    namespace x
    {
        class Teste
        {
            string nome = "";
            public Teste(string nomeConstrutor)
            {
                nome = nomeConstrutor;
            }

            public void Metodo()
            {
                Console.WriteLine($"Ola do arquivo teste {nome}");
            }

        }
    }
}