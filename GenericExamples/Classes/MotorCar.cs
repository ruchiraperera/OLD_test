using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Classes
{
    public class MotorCar : ICar
    {
        public string CarType { get; set; }
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
    }
}
