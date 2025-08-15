namespace CursoCSharp.ClassesEMetodos;

class Produto
{
    public string Nome;
    public int Preco;
    
    public static double TaxaEntrega = 0.1;

    public Produto(string nome, int preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public double CalcularEntrega()
    {
        return TaxaEntrega * Preco;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n" +
               $"Preco: {Preco}\n" +
               $"Taxa de Entrega: {this.CalcularEntrega().ToString("F2")}";
    }
}
public class AtributosEstaticos
{
    public static void Executar()
    {
        var p1 = new Produto("Celular", 90);
        var p2 = new Produto("TV", 112);
        var p3 = new Produto("Carro", 150);
        var p4 = new Produto("Sofá", 10);
        
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine(p4);
    }   
}