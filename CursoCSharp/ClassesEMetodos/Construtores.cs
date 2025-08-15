namespace CursoCSharp.ClassesEMetodos;


class Carro
{
    public string Modelo;
    public string Fabricante;
    public int Ano;

    public Carro(string modelo, string fabricante, int ano)
    {
        this.Modelo = modelo;
        this.Fabricante = fabricante;
        this.Ano = ano;
    }

    public Carro()
    {
        
    }

    public override string ToString()
    {

        return $"{this.Fabricante}, {this.Ano}, {this.Modelo}";
    }
    
}
public class Construtores
{
    public static void Executar()
    {
        var carro1 = new Carro();
        carro1.Fabricante = "BMW";
        carro1.Ano = 2002;
        carro1.Modelo = "325i";
        
        Console.WriteLine($"{carro1.Fabricante} {carro1.Ano} {carro1.Ano}");


        var carro2 = new Carro("325i", "BMW", 2002);
        
        Console.WriteLine(carro2.ToString());

        var carro3 = new Carro()
        {
            Fabricante = "BMW",
            Ano = 2002,
            Modelo = "325i",
        };
        
        Console.WriteLine(carro3.ToString());
    }
}