using LSPBirdsSolutionApp.Model;

namespace LSPBirdsSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turkey turkey = new Turkey("Turkey 1");
            Sparrow sparrow = new Sparrow("Sparrow 1");
            Crow crow = new Crow("Crow 1");
            sparrow.Fly();
            crow.Fly();
            //turkey.Fly();
        }
    }
}