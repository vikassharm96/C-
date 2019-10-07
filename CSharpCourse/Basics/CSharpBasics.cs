using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpCourse.Basics
{
    public class CSharpBasics
    {
        public void PrimitiveTypes()
        {
            const float PiValue = 3.14f;

            //Type conversion
            byte b = 1;
            int imp = b; // implicit type conversion 1byte to 4byte with prefix 0
            imp = 1;
            byte exp = (byte)imp; // explicit type conversion
            string str = "1";
            var noncomp = Convert.ToInt32(str); // non compatible type conversion
            noncomp = int.Parse(str); // we can use convert class or parse method

            // Bitwise operator
            int i = 5;
            int j = 7;
            Console.WriteLine("i&j = {0}", (i & j)); // 0101(5) & 0111(7) = 0101(5)
            Console.WriteLine("i|j = {0}", (i | j)); // 0101(5) | 0111(7) = 0111(7)
            Console.WriteLine("i^j = {0}", (i ^ j)); // 0101(5) ^ 0111(7) = 0010(2)
            Console.WriteLine("~i = {0}", ~i); // ~ 0101(5) = 1010 (10)
            Console.WriteLine("i<<2 = {0}", (i << 2)); // 0000 0101(5) << 2 = 0001 0100(20) 5*(2pow2)
            Console.WriteLine("j>>2 = {0}", (j >> 2)); // 0000 0111(7) >> 2 = 0000 0001(1) 7/(2^2)

            try
            {
                checked
                {
                    byte number = 255;
                    number = (byte)(number + 1);
                    // which mekes 0 so to prevent from overflow we have checked which makes
                    // overflow not happen at runtime it crashes
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Overflow {0}", e.Message);
            }
            Console.WriteLine("Hello World! {0}", PiValue);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        }

        public void MakeOld(Person person)
        {
            person.age += 10;
            var random = new Random();
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                // A - 65, a - 97 ASCII Code
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);

            while (true)
            {
                Console.WriteLine("Enter your name!");
                string input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo : " + input);
                    continue;
                }
                break;
            }
        }
    }

    public class Person
    {
        public string firstName;
        public string lastName;

        public int age;

        public void Introduce() => Console.WriteLine("Name is " + firstName + " " + lastName);

        public void NonPrimitiveTypes()
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
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName, true);
            // whenever we see Type object we have to use typeof() operator
        }

        public void ArraysAndLists()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a: {0}, b: {1}", a, b);

            var firstArray = new int[] { 1, 2, 3 };
            var secondArray = firstArray;
            secondArray[0] = 0;
            Console.WriteLine(string.Format("firstArray[0]: {0}, secondArray[0]: {1}", firstArray[0], secondArray[0]));

            // Arrays - Rectangle or Jagged array
            var matrix = new int[2, 3] // rectangle array
            {
                {1,2,3 },
                { 4,5,6}
            };

            var arrayJagged = new int[2][];
            arrayJagged[0] = new int[2];
            arrayJagged[1] = new int[3];
            arrayJagged[0][0] = 1;
            // Array - fixed size
            int[] numbers = { 5, 1, 6, 2, 9 };
            // IndexOf
            var index = Array.IndexOf(numbers, 6);
            // Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear");
            foreach (var n in numbers)
                Console.WriteLine(n);
            // Copy
            int[] copyTo = new int[3];
            Array.Copy(numbers, copyTo, 3);
            Console.WriteLine("Effect of Copy");
            foreach (var n in numbers)
                Console.WriteLine(n);
            // Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort");
            foreach (var n in numbers)
                Console.WriteLine(n);
            // Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // List - dynamic size
            var list = new List<int>() { 1, 5, 3 };
            // Add
            list.Add(5);
            // AddRange
            list.AddRange(new int[3] { 4, 5, 6 }); // it needs IEnumerable which is interface
            // whenever we saw IEnumerable we can use array or list there which implement it.
            Console.WriteLine("List - ");
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
            // IndexOf
            list.IndexOf(4);
            // LastIndexOf
            list.LastIndexOf(5);
            // Remove
            list.Remove(1);
            // Count
            _ = list.Count;
            try
            {
                foreach (var number in list)
                {
                    if (number == 5)
                    {
                        list.Remove(number); // unhandled exception application crash
                        // in c# we don't allow modify collection inside foreach loop
                        // solved by using simple for loop
                    }
                }

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 5)
                {
                    list.Remove(list[i]);
                }
            }
            // Clear
            list.Clear();
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

    public class WorkingWith
    {
        // var dateTime = new DateTime(2019, 2, 14); // var not allowed with class level declaration

        public void DateTimeEg()
        {
            var dateTime = new DateTime(2019, 2, 14);
            var now = DateTime.Now;
            var today = DateTime.Today; // irrespective of time
            Console.WriteLine("Hour {0}: Minute {1}", now.Hour, now.Minute);
            now.AddDays(-1);
            Console.WriteLine(now.ToLongDateString() + " " + now.ToLongTimeString());
            Console.WriteLine(now.ToString()); // show both
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            var timeStamp = new TimeSpan(1,2,3);
            var timeSt = new TimeSpan(1, 0, 0); // same as TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            Console.WriteLine("Duration : {0}", end - start);
            Console.WriteLine("Minutes : " + timeStamp.Minutes);
            Console.WriteLine("TotalMinutes : " + timeStamp.TotalMinutes);
            Console.WriteLine("Add : " + timeStamp.Add(TimeSpan.FromMinutes(8)));
        }

        public void FilesEg()
        {
            // File, FileInfo - provide methods for creating, deleting, moving, and openings of file.
            // File provides static methods and FileInfo provides instance methods.
            // We use file when small operations to be done as every time we access static methods security
            // checking is done but in case of FileInfo security checking done once so performance improves.

            // Directory, DirectoryInfo - Directory provides static methods and DirectoryInfo provides instance methods.
            // Path class - provide methods to work with string that contain directory or file path info.

            var path = @"c:\test\file";
            File.Copy(@"c:\temp\file", @"d:\temp\file", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                var read = File.ReadAllText(path);
            }

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:\temp\file", true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }

            Directory.CreateDirectory(@"c:\temp\newfolder");
            var files = Directory.GetFiles(@"c:\projects", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(@"c:\projects", "*.sln*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo(@"c:\dummy\path");
            directoryInfo.GetFiles();

            var defaultPath = @"c:\path\dummyproject\a.sln";
            var dotIndex = defaultPath.IndexOf('.');
            var extension = defaultPath.Substring(dotIndex);

            Console.WriteLine("Extension : "+ Path.GetExtension(defaultPath));
            Console.WriteLine("File Name : "+ Path.GetFileName(defaultPath));
            Console.WriteLine("File Name Without Extension : "+ Path.GetFileNameWithoutExtension(defaultPath));
            Console.WriteLine("Directory Name : "+ Path.GetDirectoryName(defaultPath));
        }
    }

    public class Logic
    {
        public void GetSmallests(List<int> numbers, int count)
        {
            if(numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "list is null");
            }
            if(count > numbers.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count must be between 1 and list count");
            }
            var smallest = new List<int>();
            while(smallest.Count < count)
            {
                var min = GetSmallest(numbers);
                smallest.Add(min);
                numbers.Remove(min);
            }

            foreach (var min in smallest)
            {
                Console.WriteLine(min);
            }
        }

        public int GetSmallest(List<int> numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}

// C# vs .Net - C# is a programming language and .Net is a framework for building applications
// on windows and .Net supports many languages like C#,F#,Vb.Net.
// .Net consist of two components 1.CLR (common language runtime) 2.Class library.
// C# program -(compiler)- Intermediate language IL code -(CLR)- Native code.
// CLR in memory job to convert IL code to matchine code process called JIT(Just in time compilation).
// Archtecture of .Net applications - Application[Assembly, Assembly] - Assembly[Namespace,Namespace] - Namespace[class,class]
// Class - Data(Attributes) represents state of application and Methods(Functions)are behaviour
// they execute code.Eg - class Car{ data - make, model, color, methods - start(), move()}.
// Namespace - container for related classes eg-for data, namespace for graphics, images.
// Assembly - containter for related namespaces. file under disk can be .exe or dll.

// C# is case sensitive language so int number and int Number are different.
// Naming Conventions - CamelCase - firstName, PascalCase - FirstName, Hungarion Notation - strFirstName
// Primitive data types - int,bool,float,byte,char and Non Primitve data type - class,string,array,enum.
// Type Conversion - 1.Implicit 2.Explicit 3.Conversion b/w non compatible types

// types to create new type
// 1. Structures - primitive types, custom struct - Value Types
// allocated on stack, memory allocation done automatically, immediately removed when out of scope
// 2. Classes - arrays, strings, custom class - Reference Types
// need to allocate memory, memory allocated on heap, garbage collected by CLR