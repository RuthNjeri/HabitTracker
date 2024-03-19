namespace Types;

public struct Mutablepoint
{
	public int X;
	public int Y;
	
	public Mutablepoint(int x, int y) => (X, Y) = (x, y);
	public override string ToString() => $"({X}, {Y})";
}
