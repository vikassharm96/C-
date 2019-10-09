using System;
namespace CSharpCourse.Intermediate
{
    public class Circle : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            //base.Draw();
        }
    }
}
