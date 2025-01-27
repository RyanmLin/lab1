﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            double dt = 1;
            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states

            Tesla3[] myTeslas = Enumerable.Range(0, fleetNumberPerType).Select(Tesla3 => new Tesla3()).ToArray();
            Mazda3[] myMazdas = Enumerable.Range(0, fleetNumberPerType).Select(Mazda3 => new Mazda3()).ToArray();
            Prius[] myPriuses = Enumerable.Range(0, fleetNumberPerType).Select(Prius => new Prius()).ToArray();
            Herbie[] myHerbies = Enumerable.Range(0, fleetNumberPerType).Select(Herbie => new Herbie()).ToArray();


            //Step 2: implement all the fleet in one list and compute states
            var myCars = new List<Car>();

            for (int i = 0; i < fleetNumberPerType; i++)
            {
                // TODO: COMPUTE UPDATED STATE HERE
                myCars.Add(new CarSimulator.Tesla3());
                myCars.Add(new CarSimulator.Mazda3());
                myCars.Add(new CarSimulator.Prius());
                myCars.Add(new CarSimulator.Herbie());
            }
            for (double t = 0; t < 60; t += dt)
            {
                for (int i = 0; i < fleetNumberPerType*4; i++)
                {
                    Console.WriteLine(i);
                    myCars[i].Drive(t);
                }
            }
        }
    }
}
