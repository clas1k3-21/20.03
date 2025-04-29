using System;

public class Homework
{
	public static void Main()
	{
		Car car = new Car();
		car.Drive(100);
		car.DisplayInfo();
		car.TypeOfEngine();
		car.CountOfDoors();
	}
	
	public class Car
	{
	    string brand;
	    int year;
	    double mileage;
	    string EngineType;
	    int doors;
	    
	    public Car()
	    {
	        this.brand = "Ауди";
	        this.year = 2020;
	        this.mileage = 0;
	        this.EngineType = "Бензин";
	        this.doors = 4;
	    }
	    
	    public void Drive(int km)
	    {
	        mileage += km;
	        
	    }
	    
	    public void DisplayInfo()
	    {
	        Console.WriteLine("Бренд машины: " + brand);
	        Console.WriteLine("Год выпуска: " + year);
	        Console.WriteLine("Пробег: " + mileage);
	    }
	    
	    ~Car()
	    {
	        Console.WriteLine("Объект уничтожен");
	        
	    }
	    
	    public void TypeOfEngine()
	    {
	        Console.WriteLine("Тип двигателя: " + EngineType);
	    }
	    
	    public void CountOfDoors()
	    {
	        Console.WriteLine("Количество дверей у машины: " + doors);
	    }
	}
}
