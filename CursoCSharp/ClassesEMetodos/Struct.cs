namespace CursoCSharp.ClassesEMetodos;


interface Ponto
{
    void MoverNaDiagonal(int delta);
    
}

struct Coordenada: Ponto
{
    public int X;
    public int Y;

    public Coordenada(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void MoverNaDiagonal(int delta)
    {
        X += delta;
        Y += delta;
    }
    
    
}
public class ExemploStruct
{
    public static void Executar()
    {
        Coordenada coordenadaInicial;
        coordenadaInicial.X = 10;
        coordenadaInicial.Y = 10;
        
        Console.WriteLine("Coordenada Inicial: " + coordenadaInicial);
        Console.WriteLine("Y = {0}", coordenadaInicial.Y);
        Console.WriteLine("X = {0}", coordenadaInicial.X);
        
        var coordenadaFinal = new Coordenada(10, 10);
        coordenadaFinal.MoverNaDiagonal(10);
        
        Console.WriteLine("Coordenada Inicial: " + coordenadaFinal);
        Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        Console.WriteLine("X = {0}", coordenadaFinal.X);
    }
}