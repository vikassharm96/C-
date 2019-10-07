using System;
using CSharpCourse.Basics;

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
            workingWith.FilesEg();
        }
    }
}
