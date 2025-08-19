namespace CursoCSharp.ClassesEMetodos;


public struct SPonto
{
    public int X;
    public int Y;
}

public class CPonto
{
    public int X;
    public int Y;
}
public class StructVsClasse
{
    public static void Executar()
    {
        SPonto ponto = new SPonto {X = 1, Y = 3};
        SPonto copiaPonto1 = ponto; // atribuição por VALOR
        ponto.X = 3;
        
        Console.WriteLine(ponto.X);
        Console.WriteLine(copiaPonto1.X);

        CPonto ponto2 = new CPonto { X = 3, Y = 4 };
        CPonto copiaPonto2 = ponto2;
        
        ponto2.X = 4;
        
        Console.WriteLine(copiaPonto2.X); //atribuição por referencia
        Console.WriteLine(ponto2.X);
        
        
    }
}