using System.Globalization;

namespace CursoCSharp.Fundamentos;

public class LendoDados
{
    public static void Executar()
    {
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();
        
        
        Console.Write("Qual é a sua idade? ");
        int idade = int.Parse(Console.ReadLine());
        
        Console.Write("Qual o seu salário? ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write($"Nome: {nome}, Idade {idade}, Salario: {salario}");
    }
}