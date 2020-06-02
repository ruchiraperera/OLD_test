using GenericExamples.Classes;
using GenericExamples.Models;
using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// new() - constraint
/// nullable reference type ? change in 8.0 ! symbol
/// CarViewModel<T> : VehicleViewModel<T> where T : ICar? this feature available in 8.0 C# ( nullable reference type)
/// </summary>

namespace GenericExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleViewModel<IVehicle> T1 = new VehicleViewModel<MotorCar>(obj: new MotorCar() { CarType = "HatchBack" });

            
            IVehicleViewModel<ICar> vehicleViewModel = new CarViewModel<MotorCar>(new MotorCar() { CarType = "HatchBack" });
            vehicleViewModel.DisplayModel();
            

            IManViewModel<IVehicle> manViewModel = new CarViewModel<MotorCar>(new MotorCar() { CarType = "HatchBack" });
            manViewModel.DisplayManView();

            //above example shows the difference between IEnumerable vs IList
            IEnumerable<string> T10 = new List<string>() { "a", "b" };
            IList<string> T101 = new List<string>() { "a", "b" };

            
            var ft = T101?.Count;

            Console.Read();
        }
    }
}
