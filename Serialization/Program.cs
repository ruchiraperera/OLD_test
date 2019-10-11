using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * [Serialization]
             * Serialization is the process of converting an object or a set of objects graph
             * into a stream, it is a byte array in the case of binary serialization
             * 
             * [NonSerialized]
             * serializable type contains a pointer, a handle, or some other data structure, then we can't convert it to serialize object
             * 
             * when serialization happen it convert to byte stream
             * 
             * what is the different between buffer and stream
             * buffer has a specific size/ length to store data
             * stream has been used to read and write information and stream itself has a buffer
             * 
             * It is used when we mark an object’s serializable [NonSerialized] -> It is used when 
             * we do not want to serialize an object’s field. [OnSerializing] -> It is used when we 
             * want to perform some action while serializing an object [OnSerialized] -> It is used 
             * when we want to perform some action after serialized an object into stream
             */

            test demo = new test();

            Stream ms = demo.SerializeToMS(demo);
            ms.Position = 0;

            test demo1 = new BinaryFormatter().Deserialize(ms) as test;

            Console.WriteLine(demo1.Id);
            Console.WriteLine(demo1.Name);

            Console.ReadKey();
        }
    }

    [Serializable] 
    //[NonSerialized]
    public class test {

        public int Id { get; set; }
        public string Name { get; set; }

        internal Stream SerializeToMS(test demo)
        {
            test objSer = new test();
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, objSer);
            return ms;
        }

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            Id = 1;
            Name = "Dayal";
        }
        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            // Do some work after serialized object
        }

    }
}
