namespace CursoCSharp.EstruturasDeControle;

public class EstruturaForEach
{
    public static void Executar()
    {
        string[] nomes = { "Kaik", "Kauan", "Angelica", "Josias" };

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}