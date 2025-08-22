using System.Data;

namespace CursoCSharp.APi;

public class ExemploDatetime
{
    public static void Executar()
    {
        var hoje = DateTime.Today;

        Console.WriteLine("Hoje é dia: {0}", hoje);

        var data = new DateTime(year : 2000, day: 20, month:2);

        Console.WriteLine("Hoje é sexta? {0}", DateTime.Today.DayOfWeek == DayOfWeek.Friday? "Sim" : "Não");
    }
}