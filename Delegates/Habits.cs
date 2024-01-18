public class Habits
{
	public required string Name;
	public string? Description;
	public required dynamic Metric; // There are different metrics out there, time, date, kgs, meters..etc
	public required dynamic Goal;
	public int Frequency = 0;
	
	public Habits(string name, string description, dynamic metric, dynamic goal)
	{
		Name = name;
		Description = description;
		Metric = metric;
		Goal = goal;
	}
	
	public string TotalFrequency()
	{
		Frequency += 1;
		
		return $"Congratulations on completing the habit {Frequency} times!";
	}
	
	public string  TrackGoal()
	{
		string goalPercentage = 
		string goalUpdate = ""
		if(Goal == Frequency)
		{
			
		}
	}
	
}