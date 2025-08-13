namespace CursoCSharp.Fundamentos;

public class Conversoes
{
    public static void Executar()
    {
        int inteiro = 10;
        double quebrado = inteiro; //conversao implicita
        
        Console.WriteLine("Valor quebrado: " + quebrado);

        double nota = 9.7;

        int notaTruncada = (int) nota; //casting
        Console.WriteLine("Valor truncado: " + notaTruncada);
        
        Console.Write("Sua idade: ");
        string idadeString = Console.ReadLine();
        int idade = int.Parse(idadeString);
        
        Console.WriteLine("Sua idade: " + idade);

        int idadeInteiro = Convert.ToInt32(idade); //outra forma de conversao explicita
        
        Console.Write("Digite o primeiro número: ");
        string palavra = Console.ReadLine();
        int numero;
        int.TryParse(palavra, out numero); // o out é para que, caso não seja possivel converter 
        //a variável ele joga um valor (por padrao 0) para ela
        
        Console.WriteLine(numero);

        Console.Write("Digite o segundo número: ");
        int.TryParse(Console.ReadLine(), out int numero2);  
        
        Console.WriteLine(numero2);

    }
}