namespace CursoCSharp.ClassesEMetodos;

public enum Genero
{
    Acao,
    Aventura,
    Terror,
    Animacao,
    Comedia
};

public class Filme
{
    public string Titulo;
    public Genero GeneroDoFilme;
}
public class ExemploEnum
{
    public static void Executar()
    {
        int id = (int)Genero.Acao;
        int id2 = (int)Genero.Animacao;
        Console.WriteLine(id);
        Console.WriteLine(id2);

        var filme = new Filme();
        filme.Titulo = "Titulo";
        filme.GeneroDoFilme = Genero.Acao;
        
        Console.WriteLine(filme.GeneroDoFilme);

    }
}