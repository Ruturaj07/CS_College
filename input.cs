

class student
{
	public static void Main()
	{
		string name;
		float percentage;
		int roll_no;
		System.Console.Write("Enter your name");
		name = System.Console.ReadLine();
		System.Console.WriteLine("Enter your Rollno.");
		roll_no = int.Parse(System.Console.ReadLine());	
		System.Console.WriteLine("Enter your percentage");
		percentage = float.Parse(System.Console.ReadLine());	

		System.Console.WriteLine("Name: "+name);
		System.Console.WriteLine("Rollno: "+roll_no);
		System.Console.WriteLine("Percentage: "+percentage);
	}

}