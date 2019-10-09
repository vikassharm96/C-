using System;
namespace CSharpCourse.Intermediate
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("car is been initialized");
        }
    }
}

// constructor and inheritance - base class constructor always executed first.
// base class constructor are not inherited.