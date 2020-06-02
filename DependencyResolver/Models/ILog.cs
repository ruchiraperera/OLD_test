using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyResolver.Models
{
    public interface ILog
    {
        void display(string message);
    }
}
