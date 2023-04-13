using LSPBirdsSolutionApp.Model;
using LSPBirdsSolutionApp.Presentation;

namespace LSPBirdsSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow LilSparrow = new Sparrow("Jack Sparrow");
            Crow crow = new Crow("Gladiator Crow");
            Turkey turkey = new Turkey("Tommy the Turkey");
            LilSparrow.Fly(LilSparrow);
            crow.Fly(crow);
            turkey.Fly(turkey);
        }
    }
}