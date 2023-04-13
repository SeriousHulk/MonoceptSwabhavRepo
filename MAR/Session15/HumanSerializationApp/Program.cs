using HumanLib.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace HumanSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humanList = CreateHumanList();
            FileStream fs = new FileStream("humanList1.dump", FileMode.Create,
                FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, humanList);
            fs.Close();
            Console.WriteLine("HumanList.Dump file has been created.");
        }
        private static Human[] CreateHumanList()
        {
            Human[] humanList = new Human[5];
            humanList[0] = new Human() { Name = "Vikrant", Age = 23, Height = 5.25f, Weight = 45.03f };
            humanList[0].Eat();
            humanList[0].Workout();
            humanList[0].Eat();
            humanList[1] = new Human() { Name = "Pradeep", Age = 22, Height = 5.2f, Weight = 49.03f };
            humanList[1].Workout();
            humanList[1].Workout();
            humanList[2] = new Human() { Name = "Mohit", Age = 21, Height = 5.34f, Weight = 41.04f };
            humanList[2].Eat();
            humanList[3] = new Human() { Name = "Rucha", Age = 23, Height = 5.11f, Weight = 41.05f };
            humanList[3].Workout();
            humanList[4] = new Human() { Name = "Shalini", Age = 24, Height = 5.34f, Weight = 50.06f };
            humanList[4].Eat();
            humanList[4].Workout();
            return humanList;
        }
    }
}