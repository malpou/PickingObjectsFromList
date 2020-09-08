using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingObjectsFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave A
            List<int> numbers = new List<int> { 4, 7, 12, 17, -3, 8, 0, -45, 101 };
            List<int> lessEqualZero = numbers.Where(x => x <= 0).ToList();
            List<int> numberSeven = numbers.Where(x => x == 7).ToList();
            List<int> biggerThanFour = numbers.Where(x => x > 4).ToList();

            WriteList(lessEqualZero);
            WriteList(numberSeven);
            WriteList(biggerThanFour);

            //Opgave B
            List<Car> cars = new List<Car>
            {
                new Car(1, "Rio", "Kia", 2006, 250000, "Red"),
                new Car(2, "Rio", "Kia", 2007, 265000, "Black"),
                new Car(3, "Panda", "Fiat", 2017, 256000, "Black"),
                new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow"),
                new Car(5, "S40", "Volvo", 2018, 665000, "White"),
                new Car(6, "S65", "Volvo", 2018, 600000, "White"),
                new Car(7, "Gorm", "Ferrari", 2000, 4665000, "White"),
                new Car(8, "Gorm", "Ferrari", 2018, 4665000, "White"),
            };
            List<Car> rio = cars.Where(car => car.Model == "Rio").ToList();
            List<Car> ferrari = cars.Where(car => car.Brand == "Ferrari").ToList();
            List<Car> newCars = cars.Where(car => car.Year >= 2010).ToList();
            List<Car> whiteCars = cars.Where(car => car.Color == "White").ToList();
            Car oneCar = cars.SingleOrDefault(car => car.Id == 8);

            WriteList(rio);
            WriteList(ferrari);
            WriteList(newCars);
            WriteList(whiteCars);
            WriteList(oneCar);
        }

        // Opgave A
        static void WriteList(List<int> list)
        {
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }

        // Opgave B
        static void WriteList(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(CarString(car));
            }
            Console.WriteLine();
        }

        static void WriteList(Car car)
        {
            Console.WriteLine(CarString(car));
            Console.WriteLine();
        }


        static string CarString(Car car)
        {
            return $"ID: {car.Id} | {car.Brand} {car.Model} ({car.Year}) | Price: {car.Price:C} | Color: {car.Color}";
        }
    }
}
