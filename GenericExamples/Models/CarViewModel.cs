using GenericExamples.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Models
{
    public class CarViewModel<T> : VehicleViewModel<T> where T : ICar
    {
        public CarViewModel(T obj) : base(obj)
        {
        }
    }
}
