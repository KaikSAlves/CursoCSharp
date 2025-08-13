namespace CursoCSharp.EstruturasDeControle;

public class EstruturaWhile
{
    public static void Executar()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 10);
        
        while (true)
        {
            Console.Write("Para sair do loop digite o numero correto entre 1 e 10: ");
            int.TryParse(Console.ReadLine(), out int numeroDigitado);

            if (numeroDigitado == numeroAleatorio)
            {
                Console.WriteLine("Parabéns! Você saiu da prisão");
                break;
            }
            else
            {
                Console.WriteLine("Não foi dessa vez... Tente novamente!");
            }
        }
    }
}