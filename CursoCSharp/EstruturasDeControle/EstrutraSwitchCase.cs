namespace CursoCSharp.EstruturasDeControle;

public class EstrutraSwitchCase
{
    public static void Executar()
    {
        Console.Write("Digite um número de 1 a 5: ");
        int.TryParse(Console.ReadLine(), out int numero);
        string resultado;
        
        switch (numero)
        {
            case 1:
                resultado = "Muito Ruim";
                break;
            case 2:
                resultado = "Ruim";
                break;
            case 3:
                resultado = "Normal";
                break;
            case 4:
                resultado = "Bom";
                break;
            case 5:
                resultado = "Muito Bom";
                break;
            default:
                resultado = "Numero inválido";
                break;
        }
        
        Console.Write("Resulado: " + resultado);
    }
}