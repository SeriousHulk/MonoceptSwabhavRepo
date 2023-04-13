using ConfigurationApp.Model;
using System;
using System.Configuration;

namespace ConfigurationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            Console.WriteLine("*****Case Study 1:*****");
            string key1 = ConfigurationManager.AppSettings["Key1"];
            Console.WriteLine($"Print value in key1 {key1}");
            string key2 = ConfigurationManager.AppSettings["Key2"];
            Console.WriteLine($"Print value in key2 {key2}\n");
        }
        private static void CaseStudy2()
        {
            string connection1 = ConfigurationManager.AppSettings["connection1"];
            string connection2 = ConfigurationManager.AppSettings["connection2"];
            Console.WriteLine("*****Case Study 2:*****");
            PrintConnection(connection1, "Printing connection 1");
            PrintConnection(connection2, "Printing connection 2");
        }
        private static void CaseStudy3()
        {
            Console.WriteLine("*****Case Study 3:*****");
            string connection1 = ConfigurationManager.AppSettings["connection1"];
            string connection2 = ConfigurationManager.AppSettings["connection2"];
            Connection connection3 = new Connection(connection1);
            Connection connection4 = new Connection(connection2);
            PrintConnection(connection3, "Printing Connection 3");
            PrintConnection(connection4, "Printing Connection 4");
        }
        public static void PrintConnection(string connection, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine($"Server1= {GetServer(connection)}; Database1= '{GetDatabase(connection)}'\n");
        }
        private static void PrintConnection(Connection connection, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine($"Server1= {connection.Server}; Database1= '{connection.DatabaseName}'\n");
        }
        static string GetServer(string getServerString)
        {
            string[] stringBlocks = getServerString.Split(';');
            foreach (string block in stringBlocks)
            {
                if (block.StartsWith("server="))
                {
                    return block.Substring(7);
                }
            }
            return "ERROR: Server name not present";
        }

        static string GetDatabase(string getDatabaseString)
        {
            string[] stringBlocks = getDatabaseString.Split(';');
            foreach (string block in stringBlocks)
            {
                if (block.StartsWith("database ="))
                {
                    Console.WriteLine("*****into GetDatabase*****");
                    return block.Substring(9);
                }
            }
            return "ERROR: Database name not present";
        }
    }
}
