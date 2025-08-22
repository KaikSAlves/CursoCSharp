namespace CursoCSharp.TopicosAvancados;

public class Nullables
{
    public static void Executar()
    {
        Nullable<int> num1 = null;
        int? num2 = null;
        Console.WriteLine("Num1 tem valor? {0}", num1.HasValue);
    }
}