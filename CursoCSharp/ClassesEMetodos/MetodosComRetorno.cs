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

    public int Dividir(int a, int b)
    {
        return a / b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}

public class CalculadoraCadeia
{
    private int memoria;

    public CalculadoraCadeia Somar(int a)
    {
        memoria += a;
        return this;
    }

    public CalculadoraCadeia Subtracao(int a)
    {
        memoria -= a;
        return this;
    }

    public CalculadoraCadeia Divisao(int a)
    {
        memoria /= a;
        return this;
    }

    public CalculadoraCadeia Multiplicacao(int a)
    {
        memoria *= a;
        return this;
    }

    public CalculadoraCadeia Imprimir()
    {
        Console.WriteLine(memoria);
        return this;
    }

    public CalculadoraCadeia Limpar()
    {
        memoria = 0;
        return this;
    }

    public int Resultado()
    {
        return memoria;
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
        
        var CalculadoraCadeia = new CalculadoraCadeia();

        CalculadoraCadeia.Somar(2).Somar(4).Imprimir().Multiplicacao(5).Imprimir().Limpar()
            .Somar(2).Subtracao(2).Divisao(1).Imprimir();

    }
}