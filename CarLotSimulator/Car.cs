﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        // DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        // DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

        //The methods should take one string parameter: the respective noise property

        public Car()
        {
            CarLot.numberOfCars++;
            // ClassName.StaticMember
        }

        public Car(int year,
                   string make,
                   string model,
                   string engineNoise,
                   string honkNoise,
                   bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; } 
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise) // void is the absene of a return type
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
