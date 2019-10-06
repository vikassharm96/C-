using System;
using CSharpCourse.Basic;

namespace CSharpCourse
{
    class MainClass
    {
        public static void Main(string[] args)
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
            Console.WriteLine("i&j = {0}", (i&j)); // 0101(5) & 0111(7) = 0101(5)
            Console.WriteLine("i|j = {0}", (i|j)); // 0101(5) | 0111(7) = 0111(7)
            Console.WriteLine("i^j = {0}", (i^j)); // 0101(5) ^ 0111(7) = 0010(2)
            Console.WriteLine("~i = {0}", ~i); // ~ 0101(5) = 1010 (10)
            Console.WriteLine("i<<2 = {0}", (i<<2)); // 0000 0101(5) << 2 = 0001 0100(20) 5*(2pow2)
            Console.WriteLine("j>>2 = {0}", (j>>2)); // 0000 0111(7) >> 2 = 0000 0001(1) 7/(2^2)

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

            var person = new Person
            {
                firstName = "vikas",
                lastName = "sharma"
            };
            person.Show();
            person.Introduce();
            person.Check();

            var newPerson = new Person { age = 10 };
            MakeOld(newPerson);
            Console.WriteLine(newPerson.age);
        }

        public static void MakeOld(Person person) // it is a refernce type object
        {
            person.age += 10;
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
