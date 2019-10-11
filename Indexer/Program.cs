using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexer
{
    //indexer
    //object like an array


    /*
     * overloading indexers
     * multi parameter indexers
     * 
     * 
     * 
     * 
     */

    public class Enrollment
    {

        public int Id { get; set; }
        public string CourseName { get; set; }
    }


    public class Customer
    {

        public List<Enrollment> enrollments = new List<Enrollment>();

        public Enrollment this[int enrollmentId]
        {

            get
            {
                return (from cd in enrollments where cd.Id.Equals(enrollmentId) select cd).FirstOrDefault();
            }

        }

        public Enrollment this[string name]
        {

            get
            {
                return (from cd in enrollments where cd.CourseName == name select cd).FirstOrDefault();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            List<Enrollment> enrollments = new List<Enrollment>();
            enrollments.Add(new Enrollment() { Id = 1, CourseName = "Maths" });
            enrollments.Add(new Enrollment() { Id = 2, CourseName = "Maths1" });
            enrollments.Add(new Enrollment() { Id = 3, CourseName = "Maths2" });

            customer.enrollments = enrollments;


            Console.WriteLine(customer[1].CourseName);
            Console.WriteLine(customer["Maths2"].CourseName);


            Console.ReadKey();
        }
    }
}
