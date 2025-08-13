namespace CursoCSharp.Fundamentos;

public class OperadorTernarios
{
    public static void Executar()
    {
        double nota = 6.0;
        string resultado = nota >= 6.0 ? "Passou" : "Reprovado";
        
        Console.WriteLine(resultado);
    }
}