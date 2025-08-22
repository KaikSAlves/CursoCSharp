namespace CursoCSharp.MetodosEFuncoes;

public class ExemploLambda
{
    public static void Executar()
    {
        Action imprimirConsole = () =>
        {
            Console.WriteLine("Executando exemplo lambda");
        };
        
        imprimirConsole();

        Func<int>
            jogarDado = () =>
        {
            Random random = new Random();
            return random.Next(1, 7);

        };

        Func<int, int> multiplicarPorDois = x => x * 2;
        
        Console.WriteLine("{0}",  jogarDado());

        Console.WriteLine("2 multiplicado por 2 é igual a: {0}", multiplicarPorDois(2));
        
        Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2}", dia, mes, ano);

        Console.WriteLine(formatarData(26, 06, 2005));
    }
    
}