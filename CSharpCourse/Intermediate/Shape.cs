using System;
namespace CSharpCourse.Intermediate
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        // with virtual and overriding there might be change that derived class don't
        // override draw method or accidently forget so to force override this we use abstract
        /*public virtual void Draw() 
        {
            Console.WriteLine();
        }*/

        public abstract void Draw();        

        public void Copy()
        {
            Console.WriteLine("copy to clipboard");
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

// Abstract classed and members
// Abstract modifier indicates that a class or a member is missing implementation.
// when we declare method or property as abstract then class that contain that is to declare abstract as well.
// abstract method are inheriently virtual and can provide polymorphic behaviour.
// Rules - 1.Abstract member do not include implementation. 2.If a member is declared as abstract, the containing class needs to
// to be declared as abstract too. 3.Derived class must implement all abstract members in the base abstract class.
// 4.abstract classes cannot be instantiated. eg - var abs = new AbstractClass() // won't compile.
// we use abstract when we want to provide some common behaviour, while forcing other developers to follow our design.

// Sealed classes and members - it is opposite of abstract classes.It prevents derivation of classes or overriding of methods.
// it can applied to class or class members.