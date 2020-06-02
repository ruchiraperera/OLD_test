using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Classes
{
    public interface ICar : IVehicle
    {
        string CarType { get; set; }
    }
}
