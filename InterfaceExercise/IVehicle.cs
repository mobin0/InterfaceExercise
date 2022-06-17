using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
       public int Wheels { get; set; }
       public bool sunRoof { get; set; }
       public bool Radio { get; set; }
       public bool Automatic { get; set; }

        public void PrintStats();
    }
}
