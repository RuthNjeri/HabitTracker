using System.Security.Cryptography.X509Certificates;

namespace Delegates;

class Program
{
	public delegate void HabitUpdate();
	static void Main(string[] args)
	{
		var habit1 = new Habit("Gym", "Exercise five times a week", "days", 208);
		//var habitgetsetfields = new Habit{ Name = "Gym", Description = "Exercise five times a week", Metric = "days", Goal = 208};
			
		var habit2 = new Habit( "Reading", "Read one hour a day", "days", 208);
			
		var habit3 = new Habit( "Swimming", "Swim once a week", "days", 208);
		
		// Using delegates
		// Delegates can be used as callbacks
		// Delegate methods can be passed to other methods as arguments
		
		// Using Delegates to update a habit once completed
		
	}
	
	//public static void 
}
