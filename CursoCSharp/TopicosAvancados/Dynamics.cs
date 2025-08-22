using System.Dynamic;

namespace CursoCSharp.TopicosAvancados;

public class Dynamics
{
    public static void Executar()
    {
        dynamic variavel = "teste";
        variavel = 2;

        variavel++;
        Console.WriteLine(variavel);

        dynamic aluno = new ExpandoObject();

        aluno.nome = "teste";
        aluno.idade = 20;
        aluno.nota = 2;

        Console.WriteLine("{0}, {1}, {2}", aluno.nome, aluno.idade, aluno.nota);
    }
}