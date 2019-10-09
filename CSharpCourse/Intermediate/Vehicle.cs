using System;
namespace CSharpCourse.Intermediate
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is been initialized");
        }
    }
}
