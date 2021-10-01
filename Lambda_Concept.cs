// C# program to illustrate the
// Lambda Expression
using System;
using System.Collections.Generic;
using System.Linq;

// User defined class Student
class Student {
	
	// properties rollNo and name
	public int rollNo
	{
		get;
		set;
	}
	
	public string name
	{
		get;
		set;
	}
}

class GFG {
	
	// Main Method
	static void Main(string[] args)
	{
		// List with eah element of type Student
		List<Student> details = new List<Student>() {
			new Student{ rollNo = 1, name = "Liza" },
				new Student{ rollNo = 2, name = "Stewart" },
				new Student{ rollNo = 3, name = "Tina" },
				new Student{ rollNo = 4, name = "Stefani" },
				new Student { rollNo = 5, name = "Trish" }
		};

		// To sort the details list
		// based on name of student
		// in acsending order
		var newDetails = details.OrderBy(x => x.name);

		foreach(var value in newDetails)
		{
			Console.WriteLine(value.rollNo + " " + value.name);
		}
	}
}