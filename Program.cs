using ClassesExcercise.Math; //adds class from a separate file (ALT + ENTER)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person(); //Person john = new Person(); //_ = new Person(); //var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}