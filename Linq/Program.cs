using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var arq = from arquivo in Directory.GetFiles(@"C:\Windows\System32")
                      let infoArquivo = new FileInfo(arquivo)
                      group infoArquivo by infoArquivo.Extension.ToUpper() into g
                      let extensao = g.Key
                      orderby extensao
                      select new
                      {
                          Extensao = extensao,
                          NumeroArquivos = g.Count(),
                          TamanhoTotalArquivosKB = g.Sum(fi => fi.Length) / 1024M,
                          TamanhoMedioArquivosKB = g.Average(fi => fi.Length) / 1024D,
                          TamanhoMenorArquivoKB = g.Min(fi => fi.Length) / 1024M,
                          TamanhoMaiorArquivoKB = g.Max(fi => fi.Length) / 1024M
                      };

            foreach (var item in arq)
                Console.WriteLine(item);

            Console.ReadLine();
        }

        private static void ExemploComWhere()
        {
            var arq = from arquivo in Directory.GetFiles(@"C:\Windows\System32")
                      let infoArquivo = new FileInfo(arquivo)
                      let tamanhoArquivoMB = infoArquivo.Length / 1024M / 1024M
                      where tamanhoArquivoMB > 1M && infoArquivo.Extension.ToUpper() == ".EXE"
                      orderby tamanhoArquivoMB
                      select new
                      {
                          Nome = infoArquivo.Name,
                          TamanhoMB = tamanhoArquivoMB
                      };

            foreach (var item in arq)
                Console.WriteLine(item);
        }

        private static void ExemploComOrdenacao()
        {
            var arq = from arquivo in Directory.GetFiles(@"C:\Windows\System32")
                      let nomeArquivo = Path.GetFileName(arquivo)
                      let extensao = Path.GetExtension(arquivo).ToUpper()
                      orderby extensao, nomeArquivo descending
                      select new
                      {
                          NomeArquivo = nomeArquivo,
                          Extensao = extensao
                      };

            foreach (var item in arq)
                Console.WriteLine(item);
        }

        private static void ExemploProjecao()
        {
            var arq = from arquivo in Directory.GetFiles(@"C:\Windows\System32")
                      select new
                      {
                          NomeArquivo = Path.GetFileName(arquivo),
                          Extensao = Path.GetExtension(arquivo)
                      };

            foreach (var item in arq)
                Console.WriteLine(item.NomeArquivo);
        }

        private static void Exemplo2()
        {
            var arq = from arquivo in Directory.GetFiles(@"C:\Windows\System32")
                      select arquivo;

            foreach (var item in arq)
                Console.WriteLine(item);
        }

        private static void Exemplo1()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var pares = from n in nums
                        where (n % 2) == 0
                        select n;

            foreach (var item in pares)
                Console.WriteLine(item);
        }
    }
}
