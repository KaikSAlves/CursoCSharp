using System.Globalization;

namespace CursoCSharp.Fundamentos;

public class FormatandoNumero
{
    public static void Executar()
    {
        double valor = 15.976132;
        
        Console.WriteLine(valor.ToString("F1")); //determina quantas casa serao utilizadas
        Console.WriteLine(valor.ToString("C")); //Transforma o numero em uma moeda (referente a localizacao)
        Console.WriteLine(valor.ToString("P")); //Transforma em porcentagem
        Console.WriteLine(valor.ToString("#.##")); //transforma nas casa determinadas

        var cultura = new CultureInfo("pt-BR");
        var cultura2 = new CultureInfo("en-US");
        
        Console.WriteLine(valor.ToString("C0", cultura)); // são as casas que o numero terá
        Console.WriteLine(valor.ToString("C0", cultura2));

        int inteiro = 256;
        
        Console.WriteLine(inteiro.ToString("D10")); // deixa o numero com 10 casas

    }
}