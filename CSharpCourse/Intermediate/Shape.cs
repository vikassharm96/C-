using System;
namespace CSharpCourse.Intermediate
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine();
        }

        public static explicit operator Shape(Text v)
        {
            throw new NotImplementedException();
        }
    }
}


// convert object to base or derived class reference
// Upcasting - conversion from a derived class to a base class. eg - Circle circle = new Circle(); Shape shape = circle;
// Downcasting - conversion from a base class to a derived class. Circle anotherCircle = (Circle) shape;
// Car car = (Car) shape; throw invalid cast exception safer way to check it we use as keyword
// Car car = (Car) obj; Car car = obj as Car; if(car!=null) { ... }
// also used is keyword if(obj is Car){ Car car = (Car) obj; }

// Method overriding - modifying the implementation of an inherited method.
// virtual and override keyword