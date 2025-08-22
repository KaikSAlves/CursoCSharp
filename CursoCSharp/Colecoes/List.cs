namespace CursoCSharp.Colecoes;

public class List
{

    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
    }
    
    public static void Executar()
    {
        var livro = new Produto("Game of Throne", 49.9);

        var carrinho = new List<Produto>();
        carrinho.Add(livro);

        Console.WriteLine($"Itens no carrinho:  {carrinho.Count}");

        Console.WriteLine("Item removido do carrinho: {0}", carrinho.Remove(livro)? "Sim" : "Não");
        
        carrinho.Clear();
        
        Console.WriteLine($"Itens no carrinho:  {carrinho.Count}");
    }
}