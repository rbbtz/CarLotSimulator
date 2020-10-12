using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args) // void is the absence of a return type
                                        // null is the absence of value
        {
            {
                //TODO

                //Instanciate Carlot at the beginning of the program,
                // and as you create a car add the car to the list.
                var lot = new CarLot();

                //DONE Create a seperate class file called Car
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property            


                //Now that the Car class is created we can instanciate 3 new cars

                //Set the properties for each of the cars
                //Call each of the methods for each car


                // Instantiation 1 (Using Dot Notation)
                var michaelsCar = new Car();
                ////////// -> personal note: the contructor is "Car();" above.

                michaelsCar.Make = "Ford";
                michaelsCar.Model = "Focus";
                michaelsCar.Year = 2013;
                michaelsCar.EngineNoise = "purr";
                michaelsCar.HonkNoise = "beep";
                michaelsCar.IsDrivable = true;

                lot.Cars.Add(michaelsCar);

                // Instantiation 2 (Object Initializer Syntax)
                var stevesCar = new Car()

                // Scope is used below with access to the listed properties
                {
                    Year = 2019,
                    Make = "Tesla",
                    Model = "Cyber Truck",
                    EngineNoise = "...",
                    HonkNoise = "brmmp",
                    IsDrivable = false
                };
                // add stevesCar to the carlot
                lot.Cars.Add(stevesCar);
               
                // Instantiation 3 (using the constructor to allow parameter values to be placed inside properties)
                var brettsCar = new Car(2015, "Honda", "Civic", "vrrooom", "vruuuga", true);

                lot.Cars.Add(stevesCar);

                // Call methods
                michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
                stevesCar.MakeEngineNoise("rev rev");
                brettsCar.MakeEngineNoise(brettsCar.EngineNoise);
                // Above ^ is the Object Initializer Syntax way


                //*************BONUS*************//

                // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

                //*************BONUS X 2*************//

                // Done - Create a CarLot class
                // Done - It should have at least one property: a List of cars

                //At the end iterate through the list printing each of car's Year, Make, and Model to the console

                Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

                foreach(Car car in lot.Cars)
                {
                    Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
                }
            }
        }
    }
}