using System;
using System.Collections.Generic;

namespace CSharpCourse.Intermediate
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
                /*switch (shape.Type) it was bad practice we have to encapsulate behaviour to their specific classes
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle");
                        break;
                }*/
            }
        }
    }
}
