using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            UseInheritance();
            UseComposition();
            UseUpcastingDowncasting();
            UseBoxingUnboxing();
            UseMethodOverriding();
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

        private static void UseInheritance()
        {
            var text = new Text
            {
                Width = 100
            };
            text.Copy();
        }

        private static void UseComposition()
        {
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }

        private static void UseUpcastingDowncasting()
        {
            Circle circle = new Circle();
            Shape shape = circle; // converting object class reference to base class reference
            // upcasting implicit, circle and shape reference to both same object in memory
            circle.Width = 100;
            shape.Width = 200;

            Console.WriteLine(circle.Width);

            // upcasting eg real world -
            StreamReader streamReader = new StreamReader(new MemoryStream());
            // StreamReader() need stream as argument which is base class of memory stream so upcast 
            var arrayList = new ArrayList();
            arrayList.Add(1); // add method needs object it implicitely convert to base object class
            arrayList.Add("Vikas");
            arrayList.Add(new Circle());
            // we don't use ArrayList() as it is not type safe we can store any type here
            // so we prefer to use more generic type List<type>
            var list = new List<string>();

            Shape shaper1 = new Circle();
            Circle circle1 = (Circle)shaper1; // downcasting

            // downcasting eg - real world
            /*private void Button_Click(object sender, EventArgs eventArgs)
            {
                // using sender. we can't find properties we need to downcast it
                // var button = (Button)sender;
            }*/
        }

        private static void UseBoxingUnboxing()
        {
            // types in c# are value type and reference type that leads to Boxing and Unboxing
            // value types stored in stack - all primitive type, struct
            // reference types stored in heap which is larger amt of memory - any classes(object,array,string)
            // Boxing - the process of converting a value type instance to an object reference.
            // eg - int number = 10; Object obj = number; or Object obj = 10; // CLR store value in heap not in stack
            // Unboxing - the process of converting a object type instance to an value reference.
            // eg - Object obj = 10; int number = (int)obj;
            // boxing and unboxing have performance penalty because of extra object creation.
            var list = new ArrayList();
            list.Add(1); // boxing happen int value type converted to object reference type
            list.Add("Vikas"); // boxing not happen
            list.Add(new DateTime()); // boxing happen

            var listAnother = new List<int>();
            listAnother.Add(1); // no boxing happen internally it store list of integer
            // boxing and unboxing have performance penalty so use generic type if exist
        }

        private static void UseMethodOverriding()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}