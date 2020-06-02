using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Classes
{
    public interface IBike : IVehicle
    {
        string HandleType { get; set; }
    }
}
