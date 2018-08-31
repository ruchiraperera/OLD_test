using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Dependency_Injection1
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = new Container(t=> {
                t.For<ILog>().Use<Log1>();
                t.For<IWrite>().Use<Write1>();
            });

            var instance = container.GetInstance<DIClass>();
            instance.logEntry("log entry message");
            instance.writeEntry("Write entry message");

            Console.Read();
        }
    }


    public class ConsoleRegistry : Registry
    {

        public ConsoleRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }


    public interface ILog
    {
        void logEntry(string message);
    }

    public class Log : ILog
    {

        public void logEntry(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }

    public class Log1 : ILog
    {
        public void logEntry(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }


    public interface IWrite
    {
        void writeEntry(string message);
    }


    public class Write : IWrite
    {
        public void writeEntry(string message)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(message);
        }
    }

    public class Write1 : IWrite
    {
        public void writeEntry(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
        }
    }

    public class DIClass
    {
        private ILog _log;
        private IWrite _write;

        public DIClass(IWrite write, ILog log)
        {
            this._log = log;
            this._write = write;
        }

        public void logEntry(string message)
        {
            _log.logEntry(message);
        }

        public void writeEntry(string message)
        {
            _write.writeEntry(message);
        }
    }


}
