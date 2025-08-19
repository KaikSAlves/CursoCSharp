namespace CursoCSharp.ClassesEMetodos;

public class ParametroPadrao
{
    public static int Somar(int a = 1, int b = 2)
    {
        return a + b;
    }

    public static void Executar()
    {
        Console.WriteLine(Somar(1));
        Console.WriteLine(Somar(b : 5));
    }
}