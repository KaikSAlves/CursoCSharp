namespace CursoCSharp.TopicosAvancados;

public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Nota { get; set; }
}
public class LINQ1
{
    public static void Executar()
    {
        var alunos = new List<Aluno>
        {
            new Aluno {Nome = "Kaik", Idade = 20, Nota = 10},
            new Aluno {Nome = "Joao", Idade = 23, Nota = 10},
            new Aluno {Nome = "Roberto", Idade = 19, Nota = 8},
            new Aluno {Nome = "Cintia", Idade = 29, Nota = 7},
            new Aluno {Nome = "Gabriele", Idade = 18, Nota = 3},
            new Aluno {Nome = "Enzo", Idade = 20, Nota = 10},
        };

        Console.WriteLine("== APROVADOS ===============");

        var aprovados = alunos.Where(a => a.Nota > 6).OrderBy(a => a.Nome);

        foreach (var aluno in aprovados)
        {
            Console.WriteLine(aluno.Nome);
        }

        var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

        Console.WriteLine("== CHAMADA ==========");

        foreach (var alunas in chamada)
        {
            Console.WriteLine(alunas);
        }

        Console.WriteLine("== APROVADOS (por idade) ===========");

        var aprovadosPorIdade =
            from aluno in alunos
            where aluno.Idade < 20
            orderby aluno.Idade
            select aluno.Nome;

        foreach (var aluno in aprovadosPorIdade)
        {
            Console.WriteLine(aluno);
        }
    }
}