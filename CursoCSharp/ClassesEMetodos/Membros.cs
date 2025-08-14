namespace CursoCSharp.ClassesEMetodos;

public class Membros
{
    public static void Executar()
    {
        Pessoa sicrano = new Pessoa();
        sicrano.Nome = "Renato";
        sicrano.Idade = 21;
        
        Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos!");
    }
}