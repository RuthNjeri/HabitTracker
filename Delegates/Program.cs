using System.Security.Cryptography.X509Certificates;

namespace Delegates;

class Program
{
	public delegate void HabitUpdate();
	static void Main(string[] args)
	{
		var habit1 = new Habits( "Gym", "Exercise five times a week", 1, 208);
			
		var habit2 = new Habits( "Reading", "Read one hour a day", 1, 208);
			
		var habit3 = new Habits( "Swimming", "Swim once a week", 1, 208);
		
		// Using delegates
		// Delegates can be used as callbacks
		// Delegate methods can be passed to other methods as arguments
		
		// Using Delegates to update a habit once completed
		
	}
	
	public static void 
}
