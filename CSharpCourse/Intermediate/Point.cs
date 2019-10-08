using System;
namespace CSharpCourse.Intermediate
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException(nameof(newLocation));

            Move(newLocation.X, newLocation.Y);
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }

        public int Add(params int[] numbers)
        {
            // params, out, ref
            // var number = int.Parse("abc"); // throw new FormatException
            bool result = int.TryParse("abc", out int num);
            if (result)
                Console.WriteLine(num);
            else
                Console.WriteLine("conversion failed!");

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
