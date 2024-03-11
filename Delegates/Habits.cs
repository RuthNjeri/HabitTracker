public class Habit
{
	// public delegate string HabitCallback(object sender, EventArgs e);
	// public event HabitCallback Progress;
	public string? Name {get; set;}
	//public string? Name {get; set;}
	//public string? Name 
	//private string? Name 
	//string? Name2;  // Private member without accessibility modifier
	public string? Description {get; set;}
	public  string? Metric {get; set;} // There are different metrics out there, time, date, kgs, meters..etc
	public  int? Goal {get; set;}
	private int _frequency = 0;
	
	private static int totalHabits;

	public Habit(string name, string description, string metric, int goal)
	{
		Name = name;
		Description = description;
		Metric = metric;
		Goal = goal;
		totalHabits += 1;
	}
	
	public void UpdateHabitFrequency()
	{
		Goal += 1;
		// HabitCallback TrackHabitProgress;
		// Progress?.Invoke(TrackHabitProgress, EventArgs.Empty);
	}
	
	/// <summary>
	/// Track the Goal and Frequency of a habit
	/// </summary>
	/// <returns></returns>
	public string TrackHabitProgress()
	{
		_frequency += 1;
		
		if(_frequency == Goal)
		{
			return $"Congratulations on reaching your goal of {Goal} {Metric} on {Name}!";
		}
		
		return $"You are making a great progess on completing the habit {_frequency} times!";
	}
	
	public static int GetTotalHabits => totalHabits;	
}