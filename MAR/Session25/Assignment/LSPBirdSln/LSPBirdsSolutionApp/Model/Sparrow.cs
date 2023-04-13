using LSPBirdsSolutionApp.Presentation;

namespace LSPBirdsSolutionApp.Model
{
    internal class Sparrow :Bird,IFlyable
    {
        public Sparrow(string name) :base(name)
        {
            SetName(name);
        }
        PrintToConsole p = new PrintToConsole();
        public override void SetName(string name) { _name = name; }
        public void Fly()
        {
            p.PrintAction(this);
        }
    }
}
