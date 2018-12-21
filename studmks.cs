using sc =System.Console;

class student
{
	public static void Main()
	{
		string name;
		float average;
		int roll_no, m1,m2;
		sc.Write("Enter your name");
		name = sc.ReadLine();
		sc.WriteLine("Enter your Rollno.");
		roll_no = int.Parse(sc.ReadLine());	

		sc.Write("Enter your marks in m1");
		m1 = int.Parse(sc.ReadLine());
		sc.Write("Enter your marks in m2");
		m2 = int.Parse(sc.ReadLine());

		sc.WriteLine("Your percentage");
		average = ((m1+m2)/2);

		sc.WriteLine("Name: "+name);
		sc.WriteLine("Rollno: "+roll_no);
		sc.WriteLine("Average: "+average);
	}

}