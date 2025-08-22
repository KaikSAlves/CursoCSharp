using System.Globalization;

namespace CursoCSharp.OO;

public class Encapsulamento
{
    public static void Executar()
    {
        
    }

    public class SubCelebridade
    {
        //Todos

        public string InfoPublic = "Tenho um instagram";
        
        //herança
        protected string CorDoOlho = "Verde";
        
        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511980513321;
        
        //herança ou  mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";
        
        //mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";
        
        //private é o padrão 
        bool UsaMuitoPhotosghop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotosghop);
            
            
            
        }
    }
    
}