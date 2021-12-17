using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] items)
        {
            foreach (T item in items)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(34);

            idades.AdicionarVarios(34,34,23);

            //ListExtensoes<int>.AdicionarVarios(idades, 23, 45);

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");

            //ListExtensoes<string>.AdicionarVarios(nomes, "João", "José");
        }
    }
}
