using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {

        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * Math.Pow(raio, 2);

            Console.Write(area);
            Console.WriteLine("A área é: " + area);

            bool estaChovendo = true;

            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45; // 0 a 255

            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // - 128 a 127

            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue; // -32.768 a 32.767
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; // -2.147.483.648 a 2.147.483.647
            Console.WriteLine("Menor int: " + menorValorInt);

            int maiorValorInt = int.MaxValue;
            Console.WriteLine("Maior int: " + maiorValorInt);

            uint populacaoBrasileira = 213_000_000; // 0 a 4.294.967.295
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine("Menor long: " + menorValorLong);
            
            ulong populacaoMundial =   8_000_000_000; // 0 a 18.446.744.073.709.551.615
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; // 7 dígitos de precisão
            Console.WriteLine("Preço do Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // 15 dígitos de precisão
            Console.WriteLine("Valor de mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // 28 dígitos de precisão
            Console.WriteLine("Distância entre estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine("Texto: " + texto);








        }
    }
}
