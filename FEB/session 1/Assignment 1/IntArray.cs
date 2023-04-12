class IntArray{
	static void Main()
	{
	  int[] Array = new int[10];
	  System.Console.WriteLine("Enter 10 Numbers:");
	  for(int i=0;i<10;i++){
	   Array[i] = int.Parse(System.Console.ReadLine());
	  }
	  System.Console.WriteLine("Entered Numbers are: ");

	  for(int i=0;i<10;i++){
	  System.Console.WriteLine(Array[i]);
   	  }
	 
	}
}