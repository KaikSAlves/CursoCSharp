namespace CursoCSharp.Colecoes;

public class ArrayList
{
    public static void Executar()
    {
        var arrayList = new System.Collections.ArrayList{ "Palavra", 3, true };

        foreach (var obj in arrayList)
        {
            Console.WriteLine("{0} => {1}", obj, obj.GetType() );
        }
    }
}