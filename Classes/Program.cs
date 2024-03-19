using System.Security.Cryptography.X509Certificates;

namespace Classes;

class Program
{
	public delegate void HabitUpdate();
	static void Main(string[] args)
	{
		var habit1 = new Habit("Gym", "Exercise five times a week", "days", 208);
		//var habitgetsetfields = new Habit{ Name = "Gym", Description = "Exercise five times a week", Metric = "days", Goal = 208};
			
		var habit2 = new Habit( "Reading", "Read one hour a day", "days", 208);
			
		var habit3 = new Habit( "Swimming", "Swim once a week", "days", 208);
		
		// Testing Refrence and Value types
		var habit1CreationDate = habit1.GetHabitCreationDate();
		Console.WriteLine($"Habit 1 was created on (copy of habit1 date to var habit1CreationDate){habit1CreationDate}");	
		
		Console.WriteLine($"Changing habit creating habit1CreationDate");
		habit1CreationDate = DateTime.Parse("2022-01-01");
		Console.WriteLine($"Habit 1 was created on {habit1CreationDate}");
		
		Console.WriteLine($"Checking object habit1 date value if it has changed");
		Console.WriteLine($"Habit 1 was created on {habit1.GetHabitCreationDate()}\n");
		
		Console.WriteLine($"Assigning public date field to habit 1");
		habit1.publicDateCreated = DateTime.Parse("2022-01-02");
		Console.WriteLine($"Habit 1 Public was created on {habit1.publicDateCreated}");
		Console.WriteLine($"creating a variable to hold the habit1 public value and changing it");
		var changePublicDateCreated = habit1.publicDateCreated;
		changePublicDateCreated = DateTime.Parse("2022-01-03");
		Console.WriteLine($"Habit 1 was created on {changePublicDateCreated }");
		Console.WriteLine($"Checking object habit1 public date value if it has changed");
		Console.WriteLine($"Habit 1 Public was created on {habit1.publicDateCreated}");
		
		//habit1.TimeLeft;
		// var habit1TimeLeft = habit1.TimeLeft;
		// 
		// Using delegates
		// Delegates can be used as callbacks
		// Delegate methods can be passed to other methods as arguments
		
		// Using Delegates to update a habit once completed
		
	}
	
	//public static void 
}
