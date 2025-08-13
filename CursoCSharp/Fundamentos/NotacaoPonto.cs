namespace CursoCSharp.Fundamentos;

public class NotacaoPonto
{
    public static void Executar()
    {
        var notacao = "ola".ToUpper().Insert(3, "World")
            .Replace("World", "Mundo");
        
        Console.WriteLine(notacao);
        Console.WriteLine("Teste".Length);

        string valorImportante = null;
        
        Console.WriteLine(valorImportante?.Length);
    }
}