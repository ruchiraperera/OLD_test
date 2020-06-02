using GenericExamples.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Models
{
    public interface IVehicleViewModel<out T> where T : IVehicle
    {
        T Obj { get; }
        void DisplayModel();
    }
}
