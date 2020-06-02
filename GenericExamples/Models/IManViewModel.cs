using GenericExamples.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples.Models
{
    interface IManViewModel<out T> where T: IVehicle
    {
        string ManName { get; set; }

        void DisplayManView();
    }
}
