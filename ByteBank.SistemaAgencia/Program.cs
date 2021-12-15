using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
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
