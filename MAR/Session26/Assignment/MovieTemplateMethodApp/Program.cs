using MovieTemplateMethodApp.Model;

namespace MovieTemplateMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanticComedy romcom = new RomanticComedy();
            HorrorComedy horrorComedy = new HorrorComedy();
            Console.WriteLine("Print Genre of RomCom");
            romcom.PrintMovieGenre();
            Console.WriteLine("\nPrint Genre of HorrorComedy:");
            horrorComedy.PrintMovieGenre();
        }
    }
}