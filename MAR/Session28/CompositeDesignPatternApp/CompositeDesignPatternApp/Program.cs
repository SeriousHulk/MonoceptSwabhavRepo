using CompositeDesignPatternApp.Model;

namespace CompositeDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
            compositeRoot.AddChild(new File("PS-1",900));
            compositeRoot.AddChild(new File("Pulp Fiction",799));
            Folder action = new Folder("Action");
            compositeRoot.AddChild(action);
            action.AddChild(new File("Die Hard",902));
            action.AddChild(new File("Terminator II", 1082));
            Folder horror = new Folder("Horror");
            compositeRoot.AddChild(horror);
            horror.AddChild(new File("The Ring",552));
            horror.AddChild(new File("The Thing", 1262));
            Folder horrorComdey = new Folder("Horror-Comedy");
            horror.AddChild(horrorComdey);
            horrorComdey.AddChild(new File("Scary Movie", 367));
            compositeRoot.Display();
        }
    }
}