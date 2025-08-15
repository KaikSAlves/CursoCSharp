namespace CursoCSharp.ClassesEMetodos;

public class Funcionario
{
    private string Nome;
    private double Salario;

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }


    public Funcionario()
    {
        
    }

    public string getNome()
    {
        return Nome;
    }

    public double getSalario()
    {
        return Salario;
    }

    public void setSalario(double salario)
    {
        Salario = salario;
    }

    public void setNome(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n" +
               $"Salario: {Salario}";
    }
}
public class GetSet
{
    public static void Executar()
    {
        var func1 = new Funcionario();
        
        func1.setNome("KAik");
        func1.setSalario(10000);

        Console.WriteLine(func1);
    }
}