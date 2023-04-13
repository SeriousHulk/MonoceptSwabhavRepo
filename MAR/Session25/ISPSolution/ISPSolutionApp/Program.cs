using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Robot robot = new Robot();
            AtCafeteria(manager);
            AtTheWorkStation(manager);
            AtTheWorkStation(robot);
            //AtCafeteria(robot);
        }

        private static void AtCafeteria(IEatWork worker)
        {
            worker.StartEat();
            worker.StopEat();
        }

        private static void AtTheWorkStation(IWork worker)
        {
            worker.StartWork();
            worker.StopWork();
        }
    }
}