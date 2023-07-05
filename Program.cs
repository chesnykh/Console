// Program.cs
using System;
using System.Runtime.ConstrainedExecution;
using ChesnykhDM34IS.Library;

namespace ChesnykhDM34IS.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Garage garage = new Garage();
			garage.Name = "Chesnykh Garage";
			garage.Address = "Menjinscogo";

			Car car1 = new Car { Owner = "Dan chesnykh", Number = "E385ОР777" };
			Car car2 = new Car { Owner = "Jaric Komarov", Number = "М637ОУ799" };
			Car car3 = new Car { Owner = "Artem Kornilow", Number = "Р111ОО77" };

			garage.Cars.Add(car1);
			garage.Cars.Add(car2);
			garage.Cars.Add(car3);

			garage.ShowAll();

			Console.WriteLine("\nSorting cars by owner...");
			garage.Cars.Sort();
			garage.ShowAll();

			Console.ReadLine();
		}
	}
}