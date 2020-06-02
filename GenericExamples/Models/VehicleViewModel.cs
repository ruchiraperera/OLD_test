using GenericExamples.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Models
{
    public class VehicleViewModel<T> : IVehicleViewModel<T>, IManViewModel<T> where T : IVehicle
    {
        public T Obj { get; }
        public string ManName { get; set; }

        public VehicleViewModel(T obj)
        {
            Obj = obj;
        }

        public void DisplayModel()
        {
            Console.WriteLine($"{Obj.Brand}");
        }

        public void DisplayManView()
        {
            Console.WriteLine($"{Obj.Brand}");
        }
    }
}
