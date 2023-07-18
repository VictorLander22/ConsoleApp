using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace ConsoleApp
{
    public abstract class Pagamento
    {
        float valor = 0;
        bool parcelado = false;
        short numeroParcela = 0;

        public virtual void Pagar()
        {

        }
    }

    class PagamentoBoleto : Pagamento
    {
        public static void GerarBoletoPDF(string nomeArquivo, string Sacado)
        {
            // Criar o documento PDF
            PdfDocument document = new();
            document.Info.Title = "Boleto";

            // Adicionar uma página ao documento
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Definir fonte e tamanho
            XFont fonte = new("Arial", 12);

            // Escrever o conteúdo do boleto no PDF
            gfx.DrawString($"Ola {Sacado} aqui esta seu boleto", fonte, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);

            // Salvar o PDF em um arquivo
            document.Save(nomeArquivo);
        }

        public override void Pagar()
        {
            string s = "";
            s += Console.ReadLine();
            GerarBoletoPDF("boleto.pdf", s);
        }
    }
}
