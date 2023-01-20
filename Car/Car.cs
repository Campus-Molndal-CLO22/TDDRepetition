namespace Cars;
public class Car
{
	public string Model { get; set; } = " Skrothög";
	public int Speed { get; set; }

	public int SpeedRatio { get; set; } = 7;

	public void Accelerate()
	{
		Speed += SpeedRatio;
	}

	public void Brake()
	{
		Speed -= SpeedRatio;
	}

	public void IncreaseSpeed(int amount)
	{
		for (int i = Speed; i < amount; i++)
		{
			Speed++;
		}
	}

	public void DecreaseSpeed(int amount)
	{
		for (int i = Speed; i > amount; i--)
		{
			Speed--;
		}
	}
}
