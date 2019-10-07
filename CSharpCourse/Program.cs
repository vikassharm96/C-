using System;
using System.Collections.Generic;
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
            //workingWith.FilesEg();

            var logic = new Logic();
            logic.GetSmallests(new List<int>() { 2, 1, 6, 9, 3, 4, 8 }, 3);
        }
    }
}
