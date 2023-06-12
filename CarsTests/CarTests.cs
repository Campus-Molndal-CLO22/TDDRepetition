using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace Cars.Tests;

[TestClass()]
public class CarTests
{
//This line creates a variable named "testCar" that is an instance of the "Car" class.
Car? testCar;

//This line is an attribute that indicates that the method "Setup()" should be run before each test in the program.
[TestInitialize] 

//This line creates the method "Setup()" which will initialize the "testCar" variable with certain values.
public void Setup()
{
    //This line creates a new instance of the "Car" class and assigns it to the "testCar" variable.
    testCar = new()
    {
        //This line sets the "Model" property of the "testCar" object to the string "Saab".
        Model = "Saab",

        //This line sets the "Speed" property of the "testCar" object to the value 100.
        Speed = 100,

        //This line sets the "SpeedRatio" property of the "testCar" object to the value 10.
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

	[TestMethod()]
	public void DecreaseSpeedTest_minimal_och_ful_kod()
	{
		testCar.DecreaseSpeed(45);
		Assert.AreEqual(45, testCar.Speed);
	}

}