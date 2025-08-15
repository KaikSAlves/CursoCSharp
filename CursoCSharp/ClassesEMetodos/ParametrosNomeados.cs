namespace CursoCSharp.ClassesEMetodos;

public class ParametrosNomeados
{

    public static void Formatar(int dia, int mes, int ano)
    {
        Console.WriteLine("{0:d2}/{1:d2}/{2}", dia, mes, ano);
    }
    public static void Executar()
    {
        Formatar(mes: 06, dia: 10, ano: 2000);
    }
}