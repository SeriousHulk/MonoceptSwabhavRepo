class StringArray{
	static void Main()
	{
	  string[] Array = new string[10];

	  System.Console.WriteLine("Enter some string data:");

	  for(int i=0;i<10;i++){
	   Array[i] = System.Console.ReadLine();
	  }

	  System.Console.WriteLine("Entered Strings are: ");

	  for(int i=0;i<10;i++){
	  System.Console.WriteLine(Array[i]);
   	  }
	}
}