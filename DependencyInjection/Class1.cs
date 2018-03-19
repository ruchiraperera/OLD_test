using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface ILOG
    {
        void print(string msg);
    }

    public class consoleLog : ILOG
    {

        public void print(string msg)
        {
            Console.WriteLine("Console log..... {0}", msg);
        }
    }

    public class sampleLog : ILOG
    {
        public void print(string msg)
        {
            Console.WriteLine("Smaple log ..... {0}", msg);
        }
    }



    public class engine
    {

        private ILOG _log;

        public engine(ILOG log)
        {
            this._log = log;
        }

        public void vehivleLog()
        {

            _log.print("engine model");
        }
    }


    public class car
    {

        public car(engine _engine)
        {
            _engine.vehivleLog();
        }


    }
}
