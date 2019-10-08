using System;
using System.Collections.Generic;

namespace CSharpCourse.Intermediate
{
    public class Customer
    {
        public static int PeopleCount; // default value = 0
        public int Id;
        public string Name; // default value = null for reference type
        public readonly List<Order> Orders = new List<Order>(); // readonly used when we want to initialize only once

        public DateTime Birthdate { get; private set; } // auto implemented property compiler generates code for us

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public void SetBirthdate(DateTime Birthdate)
        {
            this.Birthdate = Birthdate;
        }

        public DateTime GetBirthdate()
        {
            return Birthdate;
        }

        // constructor overloading
        public Customer() {
            // readonly only assigned in constructor or a variable initilizer
            Orders = new List<Order>();
        }

        public Customer(int id) : this() {
            this.Id = id;
        }

        public Customer(string name, int id) : this(id)
        {
            this.Name = name;
            //this.Id = id;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Customer Parse(string name)
        {
            var customer = new Customer // object initialization syntax
            {
                Name = name
            };
            return customer;
        }
    }
}

// class members
// 1.Instance - accessible from object eg - var human = new Human(); human.Introduce();
// 2.static - accessible from class eg - Console.WriteLine()
// why use static members - to have one instance in memory
// to represent concepts that are singleton eg - DateTime.Now(), Console.WriteLine()

// constructor - a method that is called when an instance of a class is created.
// why - to put object in an early state, constructor don't have return type.
// object initializer - initialize object without need to call one of its constructor.

// methods - overloading methods same name but different signature.

// Access Modifiers - 1.Public 2.Private 3.Protected 4.Internal 5.Protected Internal.
// Object oriented concepts - 1.Encapsulation(Information hiding) 2.Inheritance 3.Polymorphism

// Indexers - a way to access elements in a class that represents a list of values.
// var cookie = new HttpCokkie(); cookie["name"] = "vikas";  cookie.SetItem("name","vikas"); var name = cookie["name"]