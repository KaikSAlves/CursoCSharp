namespace CursoCSharp.ClassesEMetodos;

public class Params
{
    public static void Executar()
    {
        Recepcionar("kaik", "Kauan", "Angelica", "Maria");
    }

    public static void Recepcionar(params string[] pessoas)
    {
        Console.WriteLine("Bem Vindo!!");
        foreach (string pessoa in pessoas)
        {
            Console.WriteLine(pessoa);
        }
    }
}