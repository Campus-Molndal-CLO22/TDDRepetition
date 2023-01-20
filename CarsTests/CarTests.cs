using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace Cars.Tests;

[TestClass()]
public class CarTests
{
	Car testCar;
	[TestInitialize] // Det ska köras innan varje test
	public void Setup()
	{
		testCar = new()
		{
			Model = "Volvo",
			Speed = 100,
			SpeedRatio=10
		};
	}


	[TestMethod()]
	public void AccelerateTest()
	{
		// Arrange
		int expected = 110;
		// Act
		testCar.Accelerate();
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void BrakeTest()
	{
		// Arrange
		int expected = 90;
		// Act
		testCar.Brake();
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void IncreaseSpeedTest()
	{
		// Arrange
		int expected = 135;
		// Act
		testCar.IncreaseSpeed(135);
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void IncreaseSpeedTest2()
	{
		// Arrange
		int expected = 100;
		int data = 90;
		// Act
		testCar.IncreaseSpeed(data);
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void DecreaseSpeedTest()
	{
		// Arrange
		int expected = 30;
		// Act
		testCar.DecreaseSpeed(expected);
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void DecreaseSpeedTest2()
	{
		// Arrange
		int expected = 100;
		int data = 120;
		// Act
		testCar.DecreaseSpeed(data);
		var actual = testCar.Speed;
		// Assert
		Assert.AreEqual(expected, actual);
	}
}