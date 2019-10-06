using System;
namespace CSharpCourse.Basic
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public int age;

        public void Show()
        {
            var num = new int[3] { 1, 2, 3 };
            string list = string.Join(",", num);
            Console.WriteLine(list);
            string name = string.Format("name is {0} {1}", firstName, lastName);
            Console.WriteLine(name);
            string path = "path is \n c:\\projects\\folders\\file \n check it!"; // to avoid escape sequence use
            string newPath = @"path is
                             c:\projects\folders\file
                             check it!";
            Console.WriteLine("{0} \n {1}", path, newPath);
            var type = ShippingMethod.express;
            int methodId = 3;
            Console.WriteLine((int)type + "\n" + (ShippingMethod)methodId);
            // cw default calls ToString() method any value we passed to it
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName, true);
            // whenever we see Type object we have to use typeof() operator
        }

        public void Introduce() => Console.WriteLine("Name is " + firstName + " " + lastName);

        public void Check()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a: {0}, b: {1}", a, b);

            var firstArray = new int[] { 1, 2, 3 };
            var secondArray = firstArray;
            secondArray[0] = 0;
            Console.WriteLine(string.Format("firstArray[0]: {0}, secondArray[0]: {1}", firstArray[0], secondArray[0]));
        }
    }

    public struct RgbColor
    {
        public int red;
        public int green;
        public int blue;
    }

    public enum ShippingMethod : byte // default enum is integer we externally chnage to byte
    {
        regularAirMail = 1,
        registeredAirMail = 2,
        express = 3
    }
}

// types to create new type
// 1. Structures - primitive types, custom struct - Value Types
// allocated on stack, memory allocation done automatically, immediately removed when out of scope
// 2. Classes - arrays, strings, custom class - Reference Types
// need to allocate memory, memory allocated on heap, garbage collected by CLR