using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Classes
{
    public class MotorBike : IBike
    {
        public string HandleType { get; set; }
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
    }
}
