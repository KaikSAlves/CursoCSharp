namespace CursoCSharp.ClassesEMetodos;

class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}

public class MetodosEstaticos
{
    public static void Executar()
    {
        Console.WriteLine("A soma de 1 + 1 é: " + Calculadora.Somar(1, 1));
    }
}