namespace CursoCSharp.Colecoes;

public class Array
{
    public static void Executar()
    {
        string[] alunos = new string[5];
        alunos[0] = "Anderson";
        alunos[1] = "Michael";
        alunos[2] = "Michael";
        alunos[3] = "Michael";
        alunos[4] = "Michael";

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}