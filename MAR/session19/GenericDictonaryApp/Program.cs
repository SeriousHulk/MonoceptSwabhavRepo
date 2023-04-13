namespace GenericDictonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();
            stateCodes.Add("AP", "Andhra Pradesh");
            stateCodes.Add("MH", "Maharashtra");
            stateCodes.Add("JK", "Jammu Kashmir");
            foreach (var row in stateCodes)
            {
                Console.WriteLine($"Key is {row.Key} and value is {row.Value}");
            }
            if (stateCodes.ContainsKey("JK"))
            {
                stateCodes.Remove("JK");
                stateCodes.Add("JK","Laddakh");
            }
            Console.WriteLine(stateCodes.Count);
            foreach(var row in stateCodes)
            {
                Console.WriteLine($"Key is {row.Key} and value is {row.Value}");
            }
            stateCodes["JK"] = "ShriNagar\n";
            Console.WriteLine("\n"+stateCodes["JK"]);
            foreach (var row in stateCodes)
            {
                Console.WriteLine($"Key is {row.Key} and value is {row.Value}");
            }
        }
        private static void CaseStudy2()
        {
            Random random = new Random();
            Dictionary<int,int> diceRoll = new Dictionary<int,int>(10);
            for (int i = 0; i < 10; i++)
            {
                int count = random.Next(1,7);
                if (diceRoll.ContainsKey(count))
                {
                    diceRoll[count]++;
                }
                else
                {
                    diceRoll[count] = 1;
                }
            }
            foreach (var row in diceRoll)
            {
                Console.WriteLine(row.Key +" " + row.Value);
            }
        }
    }
}