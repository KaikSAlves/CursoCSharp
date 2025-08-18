namespace CursoCSharp.ClassesEMetodos;

public class Cliente
{
    public string Nome;
    public readonly DateTime Nascimento;

    public Cliente(string nome, DateTime nascimento)
    {
        Nome = nome;
        nascimento = nascimento;
    }

    public string GetDataNascimento()
    {
        return String.Format("{0}/{1}/{2}", Nascimento.Day,
            Nascimento.Month, Nascimento.Year);
    }
    
    
}


public class Readonly
{
    public static void Executar()
    {
        var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));
        
        Console.WriteLine(novoCliente.Nome);
        Console.WriteLine(novoCliente.GetDataNascimento());
    }
}