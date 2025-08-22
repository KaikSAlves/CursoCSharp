namespace CursoCSharp.OO;


public class Carro
{
    protected readonly int VelocidadeMaxima;
    private int VelocidadeAtual;

    public Carro(int velocidadeMaxima)
    {
        this.VelocidadeMaxima = velocidadeMaxima;
    }
    
    public Carro()
    {
    }

    protected int AlterarVelocidade(int delta)
    {
        int novaVelocidade = VelocidadeAtual + delta;
        if (novaVelocidade < 0)
        {
            VelocidadeAtual = 0;
        }else if (novaVelocidade > VelocidadeMaxima)
        {
            VelocidadeAtual = VelocidadeMaxima;
        }
        else
        {
            VelocidadeAtual = novaVelocidade;
        }
        
        return VelocidadeAtual;
    }

    public virtual int Acelerar()
    {
        return AlterarVelocidade(5);
    }

    public int Frear()
    {
        return AlterarVelocidade(-5);
    }
    
    
}

public class Uno : Carro
{
    public Uno() : base(200)
    {

    }
}

public class Ferrari : Carro
{
    public Ferrari() : base(350)
    {
        
    }

    public override int Acelerar()
    {
        return AlterarVelocidade(15);
    }

    public new int Frear()
    {
        return AlterarVelocidade(-15);
    }

}

public class Heranca
{
    public static void Executar()
    {
        Console.WriteLine("Uno>>");
        
        Uno uno = new Uno();

        Console.WriteLine(uno.Acelerar());
        Console.WriteLine(uno.Acelerar());
        Console.WriteLine(uno.Frear());
        Console.WriteLine(uno.Frear());

        Console.WriteLine("Ferrari>>");

        Carro ferrari = new Ferrari(); //polimorfismo
        
        Console.WriteLine(ferrari.Acelerar());
        Console.WriteLine(ferrari.Acelerar());
        Console.WriteLine(ferrari.Frear());
        Console.WriteLine(ferrari.Frear());

    }
}