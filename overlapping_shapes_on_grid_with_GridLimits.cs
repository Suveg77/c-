using System;

namespace GeometryInteraction
{
    public class Shape
    {
        public int X { get; set; } 
        public int Y { get; set; } 

        public int UserInput;

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }


        public static bool ValidInput(string input)
        {
            int temp;
            return int.TryParse(input, out temp);
        }

        public virtual bool Overlaps(Shape other)
        {
            return false;
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override bool Overlaps(Shape other)
        {
            if (!(other is Rectangle otherRect))
                return false;

            return X < otherRect.X + otherRect.Width &&
                   X + Width > otherRect.X &&
                   Y < otherRect.Y + otherRect.Height &&
                   Y + Height > otherRect.Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for the first rectangle:");
            Rectangle rect1 = CreateRectangle();

            Console.WriteLine("Enter details for the second rectangle:");
            Rectangle rect2 = CreateRectangle();

            bool overlaps = rect1.Overlaps(rect2);
            Console.WriteLine($"Do the rectangles overlap? {overlaps}");
        }

        static Rectangle CreateRectangle()
        {
            int x;
            int y;
            int width;
            int height;
            for (; ; )
            {
                Console.WriteLine("X-Axis: ");
                string input1= Console.ReadLine();

                if (int.TryParse(input1, out x)&& x<101 && x>  -1)
                {
                    break; 
                }
                
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.Input must be under 101 as the grid size is limited to 100");
                }

            }

          

            for (; ; )
            {
                Console.WriteLine("Y-Axis: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out y) && y < 101 && y > -1)
                {
                    break; 
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.Input must be under 101 as the grid size is limited to 100");
                }

            }



            for (; ; )
            {
                Console.WriteLine("Width: ");
                string input3 = Console.ReadLine();

                if (int.TryParse(input3, out width) && width>-1 &&( width+x <101) && (width + y <101))
                {
                    break; 
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Width length from point of origin should be less then 101  ");
                }

            }


            for (; ; )
            {
                Console.WriteLine("height: ");
                string input4 = Console.ReadLine();

                if (int.TryParse(input4, out height) && height > -1 && (height + x < 101) && (height + y < 101))
                {
                    break; 
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("height length from point of origin should be less then 101  ");
                }

            }

            return new Rectangle(x, y, width, height);
        }
    }
}