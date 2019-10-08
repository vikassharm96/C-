using System;
using System.Collections.Generic;
using CSharpCourse.Basics;
using CSharpCourse.Intermediate;

namespace CSharpCourse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cSharpBasics = new CSharpBasics();
            cSharpBasics.PrimitiveTypes();
         
            var person = new Person
            {
                firstName = "vikas",
                lastName = "sharma"
            };
            person.NonPrimitiveTypes();
            person.Introduce();
            person.ArraysAndLists();

            var newPerson = new Person { age = 10 };
            cSharpBasics.MakeOld(newPerson); // instead of copy refernced of the object is passed
            Console.WriteLine(newPerson.age); // both point to same location in heap

            var workingWith = new WorkingWith();
            workingWith.DateTimeEg();
            //workingWith.FilesEg();

            var logic = new Logic();
            logic.GetSmallests(new List<int>() { 2, 1, 6, 9, 3, 4, 8 }, 3);

            var customer = Customer.Parse("vikas");
            customer.Introduce("sharma");
            var order = new Order();
            customer.Orders.Add(order);
            //customer.Birthdate = new DateTime(1996, 2, 14);
            customer.SetBirthdate(new DateTime(1996, 2, 14));
            Console.WriteLine(customer.Age);
            UsePoints();
            UseIndexers();
        }

        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                Console.WriteLine(point.Add(1,2,3,4,5));
                Console.WriteLine(point.Add(new int[] { 1, 2, 3, 4, 5 }));
            }
            catch (Exception)
            {
                Console.WriteLine("unexpected error occured!");
            }
        }

        public static void UseIndexers()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "vikas";
            Console.WriteLine(cookie["name"]);
        }
    }
}
