using System;
namespace CSharpCourse.Intermediate
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added link to " + url);
        }
    }
}

// class coupling - coupling means measure of how interconnected classes and subsystems are.
// how? understanding - 1.Encapsulation 2.The relationships between classes 3.Interfaces.
// Types of relationship - 1.Inheritance 2.Composition favour composition over inheritance
// Inheritance - a kind of relationship between two classes that allows one to inherit code from other 
// also called Is-A relationship eg - A car is a vehicle. benifits - code reuse, polymorphic behaviour