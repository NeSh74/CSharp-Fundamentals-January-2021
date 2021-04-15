using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Need_For_Speed3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                var name = carInfo[0];
                var mileage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);
                cars.Add(name, new List<int>()
                {
                    mileage ,fuel
                });
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                var tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var carName = tokens[1];
                switch (action)
                {
                    case "Drive":
                        var distance = int.Parse(tokens[2]);
                        var fuel = int.Parse(tokens[3]);

                        var carFuel = cars[carName][1];
                        if (fuel > carFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[carName][0] += distance;
                            cars[carName][1] -= fuel;
                            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[carName][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            cars.Remove(carName);
                        }
                        break;
                    case "Refuel":
                        int fuelToAdd = int.Parse(tokens[2]);
                        int currentFuel = cars[carName][1];
                        if (fuelToAdd + currentFuel > 75)
                        {
                            fuelToAdd = 75 - currentFuel;
                        }

                        cars[carName][1] += fuelToAdd;
                        Console.WriteLine($"{carName} refueled with {fuelToAdd} liters");
                        break;
                    case "Revert":
                        var kilometers = int.Parse(tokens[2]);
                        cars[carName][0] -= kilometers;
                        if (cars[carName][0] < 10000)
                        {
                            cars[carName][0] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                        }

                        break;
                }
                command = Console.ReadLine();
            }

            var ordered = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
