using ISPViolationApp.Model;

namespace ISPViolationApp
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
            AtCafeteria(robot);
        }

        private static void AtCafeteria(IWorker worker)
        {
            worker.StartEat();
            worker.StopEat();
        }

        private static void AtTheWorkStation(IWorker worker)
        {
            worker.StartWork();
            worker.StopWork();
        }
    }
}