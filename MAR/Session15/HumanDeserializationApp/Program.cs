using HumanLib.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HumanDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            Console.WriteLine("\n********CaseStudy1************");
            FileStream fs = new FileStream("humanList.dump", FileMode.Open,
                            FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(fs);
            Human[] humans = obj as Human[];
            foreach (Human human in humans)
            {
                Console.WriteLine("\nName :" + human.Name);
                Console.WriteLine("Age :" + human.Age);
                Console.WriteLine("Weight :" + human.Weight);
                Console.WriteLine("Height :" + human.Height);
            }
            fs.Close();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("\n********CaseStudy2************");
            FileStream fs = new FileStream("humanList1.dump", FileMode.Open,
                            FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(fs);
            Human[] humans = obj as Human[];
            foreach (Human human in humans)
            {
                Console.WriteLine("\nName :" + human.Name);
                Console.WriteLine("Age :" + human.Age);
                Console.WriteLine("Weight :" + human.Weight);
                Console.WriteLine("Height :" + human.Height);
            }
            fs.Close();
        }
    }
}