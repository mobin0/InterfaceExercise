﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck:IVehicle, ICompany
    {
        public int BedSize { get; set; }

        public string Name { get; set; }
        public bool Active { get; set; }
        public int Wheels { get; set; }
        public bool sunRoof { get; set; }
        public bool Radio { get; set; }
        public bool Automatic { get; set; }


        public void PrintStats()
        {
            string hasSunRoof = $"has a {(sunRoof ? "sunroof" : "no sunroof")}";
            string hasRadio = $"has a {(Radio ? "radio" : "no radio")}";
            string hasAutomatic = $"has {(Automatic ? "automatic" : "manual")}";
            string isActive = $"which is {(Active ? "an active" : "not currenty an active")} Company";
            string type = $"{this.GetType().Name}";

            Console.WriteLine($"{Name}, {isActive}, made this {type} which has a Bed Size of {BedSize}, has {Wheels} wheels, {hasSunRoof}, {hasRadio}, and {hasAutomatic} transmission.");
        }
    }
}
