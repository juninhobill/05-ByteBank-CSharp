using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modulo6Testes();
            //Modulo7TestesArray();
            //Modulo7ArrayContaCorrente();
            //Modulo7ListaContaCorrente();
            //Modulo7ListaCliente();
            //Modulo7Lista();
            //Modulo8TestaSort();
            Modulo8ListaCC();

        }

        public static void Modulo8ListaCC()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(678, 234234),
                new ContaCorrente(341, 1),
                null,
                new ContaCorrente(879, 999999),
                new ContaCorrente(098, 657555),
                null,
                null
            };

            //contas.Sort(); --> Chamar a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var listaSemNulos = new List<ContaCorrente>();

            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    listaSemNulos.Add(conta);
                }
            }

            //IEnumerable<ContaCorrente> contasNaoNulas = contas.Where(conta => conta != null);

            //IOrderedEnumerable<ContaCorrente> contasOrdenada =
            //    contasNaoNulas.OrderBy<ContaCorrente, int>(conta => conta.Numero);

            //var contasOrdenada =
            //    contasNaoNulas.OrderBy(conta => conta.Numero);

            var contasOrdenada = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenada)
            {

                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        public static void Modulo8TestaSort()
        {
            var nomes = new List<string>()
            {
                "Guilherme",
                "Ana",
                "Wellington",
                "Luana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(32);
            idades.Add(43);
            idades.Add(12);

            idades.AdicionarVarios(23, 23, 32, 12, 43);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }

        public static void Modulo7Lista()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(32);
            idades.Add(43);
            idades.Add(12);

            //ListExtensoes.AdicionarVarios(idades, 1, 32, 32, 34);

            idades.AdicionarVarios(23,23,32,12,43);

            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }

        public static void Modulo7ListaCliente()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar(6);
            listaDeIdades.AdicionarVarios(16,32,60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

            Console.ReadLine();
        }

        public static void Modulo7ListaContaCorrente()
        {
            Console.WriteLine(SomarVarios(1, 2, 3, 4, 635634, 54));
            Console.WriteLine(SomarVarios(1,2,3,4,54));

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 111111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
            new ContaCorrente(876, 874563),
            new ContaCorrente(876, 213213)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
            new ContaCorrente(876, 874563),
            new ContaCorrente(876, 213213)
            );

            //lista.EscreverListaNaTela();
            //lista.Remover(contaDoGui);
            //Console.WriteLine("Após remover o item");
            //lista.EscreverListaNaTela();

            for (int i = 0; i < lista.Tamanho; i++)
            {

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        public static void Modulo7ArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(123, 123123),
                new ContaCorrente(432, 423423),
                new ContaCorrente(342, 213132)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta {i} {contas[i]}");
            }

            Console.ReadLine();
        }

        public static void Modulo7TestesArray()
        {
            // ARRAY inteiros com 5 posições

            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 34;
            idades[2] = 32;
            idades[3] = 12;
            idades[4] = 32;
            idades[5] = 65;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for(int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Média de idades = {media}");

            Console.ReadLine();
        }

        public static void Modulo6Testes()
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 23424);
            object desenvolvedor = new Desenvolvedor("13213213");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado: " + contaToString);
            Console.WriteLine(conta);


            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "213123123123";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "213123123123";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_1 = new ContaCorrente(3123, 123213);

            if (carlos_1.Equals(conta_1))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9][-][0-9]";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-?[0-9]{4}";
            //string textoTeste = "Meu nome é Guilherme, me ligue em 97852-9658";

            //Console.WriteLine(Regex.Match(textoTeste, padrao));

            // pagina?argumentos
            // 012345678

            //string urlTeste = "http://www.bytebank.com.br/cambio";
            //int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            //Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com.br/cambio"));
            //Console.WriteLine(urlTeste.EndsWith("cambio"));

            //Console.WriteLine(urlTeste.Contains("bytebank"));

            //Console.WriteLine(indiceByteBank == 0);

            //string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            //ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(urlParametros);

            //string valormoedaOrigem = extrator.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + valormoedaOrigem);

            //string valormoedaDestino = extrator.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valormoedaDestino);

            //Console.WriteLine(extrator.GetValor("VALOR"));

            //string testeRemocao = "primeiraParte&parteRemover";
            //int indiceEComercial = testeRemocao.IndexOf("&");
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf("pagina");

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
