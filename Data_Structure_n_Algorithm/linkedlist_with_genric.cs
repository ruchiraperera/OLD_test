using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_n_Algorithm
{
    class linkedlist_with_genric
    {
    }

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
}
