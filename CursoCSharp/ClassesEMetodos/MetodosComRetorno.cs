namespace CursoCSharp.ClassesEMetodos;

public class CalculadoraComum
{
    public double Somar(double c, double d)
    {
        return c + d;
    }
    
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a , int b)
    {
        return a / b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}

public class MetodosComRetorno
{
    public static void Executar()
    {
        var calc = new CalculadoraComum();
        
        Console.WriteLine("Informe dois valores inteiros para serem processados na calculadora: ");
        int.TryParse(Console.ReadLine(), out int v1);
        int.TryParse(Console.ReadLine(), out int v2);
        
        Console.WriteLine($"Soma {v1} + {v2} : {calc.Somar(v1, v2)}");
        Console.WriteLine($"Divisão {v1} / {v2} : {calc.Dividir(v1, v2)}");
        Console.WriteLine($"Multiplicar {v1} * {v2} : {calc.Multiplicar(v1, v2)}");
        Console.WriteLine($"Subtração {v1} - {v2} : {calc.Subtrair(v1, v2)}");
    }
}