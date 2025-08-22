namespace CursoCSharp.MetodosEFuncoes;

delegate double Operacao(double x, double y);
public class LambdaDelegate
{
    public static void Executar()
    {
        Operacao sum = (x,y ) =>  x + y;
        Console.WriteLine("Soma 2 + 2: {0}", sum(2, 2));
    }
}