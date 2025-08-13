namespace CursoCSharp.EstruturasDeControle;

public class Estruturaif
{
    public static void Executar()
    {
        Console.Write("Informe a média e a porcentagem de presença do aluno (consecutivamento): ");
        double.TryParse(Console.ReadLine(), out double media);
        double.TryParse(Console.ReadLine(), out double presenca);
        string resultado;

        if (media < 6 && presenca < 80 )
        {
            resultado = "Reprovado";
        } else if (media < 6 && presenca >= 80)
        {
            resultado = "Recuperacao";
        } else if (media >= 6 && presenca >= 80)
        {
            resultado = "Aprovado";
        } else if (media >= 6 && presenca < 80)
        {
            resultado = "Reprovado";
        }
        else
        {
            resultado = "Reprovado";
        }
        
        Console.WriteLine("Resulado: {0}", resultado);
    }
}