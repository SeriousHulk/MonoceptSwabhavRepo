namespace AnagramApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintResult(IsAnagram("Heart", "Earth"));
            PrintResult(IsAnagram("abc", "poc"));
            PrintResult(IsAnagram("Eleven plus two", "Twelve plus one"));
        }
        public static bool IsAnagram(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] charArr1 = str1.ToCharArray();
            char[] charArr2 = str2.ToCharArray();
            Array.Sort(charArr1);
            Array.Sort(charArr2);
            for (int i = 0; i < charArr1.Length; i++)
            {
                if (charArr1[i] != charArr2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("They are anagrams");
            }
            else 
            {
            Console.WriteLine("They are not anagrams");
            }
        }
    }
}