using LSPBirdsSolutionApp.Model;
namespace LSPBirdsSolutionApp.Presentation
{
    public class PrintToConsole
    {
        public void PrintAction(Bird bird) 
        {
            Console.WriteLine($"{bird.GetName()} is Flying");
        }
    }
}
