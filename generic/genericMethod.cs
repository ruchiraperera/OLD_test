using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    public class genericMethod
    {
        public T display<T>(T _t, string name)
        {
            return _t;
        }


        public void dictionaryD<Tkey, Tvalue>(Tkey name, Tvalue Fname)
        {


        }

        // T can be a contraint that's what it means
        //add you must define contraint at last....
        public T display<T>(T a, T b) where T : IComparable, new()  {
            return new T();
        }

        //where T : class
        //where T : struct // T equal value type
        //where T : product
        //where T : Icomparable 
        //where T :new() - intialise object
        public T compare<T>(T a, T b) where T : IComparable
        {

            return a.CompareTo(b) > 0 ? a : b;

        }
    }

    //where T : class
    //where T : struct // T equal value type
    //where T : product
    //where T : Icomparable 
    //where T :new() - intialise object
    public class genricClass1<T> where T : class {


    }

    #region Best example for generic

    internal class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student Next { get; set; }
    }



    internal class testLinkedList<T> where T : class

    {
        public T _first;

        public testLinkedList(T _object)
        {
            _first = _object;
        }


        public void insert(T _obj)
        {

            T demo = _first;

            while (demo.GetType().GetProperty("Next").GetValue(demo) != null)
            {
                demo = (T)demo.GetType().GetProperty("Next").GetValue(demo);
            }

            demo.GetType().GetProperty("Next").SetValue(demo, _obj);

        }



    }


    #endregion
}
