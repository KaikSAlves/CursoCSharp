namespace CursoCSharp.TopicosAvancados;

public class LINQ2
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

        var enzo = alunos.Single(a => a.Nome.Equals("Enzo"));

        Console.WriteLine($"{enzo.Nome} {enzo.Nota} {enzo.Idade}");

        Console.WriteLine("Informe o nome do aluno: ");
        string nomeFulano = Console.ReadLine();

        var fulano = alunos.SingleOrDefault(a => a.Nome.Equals(nomeFulano));
        if (fulano == null)
        {
            Console.WriteLine("Aluno não encontrado");
        }
        else
        {
            Console.WriteLine("Aluno {0} encontrado! Dados: Nome - {1}, Idade - {2}, Nota - {3}",
                fulano.Nome, fulano.Nome, fulano.Idade, fulano.Nota);
        }
    }
}