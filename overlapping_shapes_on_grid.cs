using System;

namespace GeometryInteraction
{
    // Base class for a geometric shape
    public class Shape
    {
        // Properties common to all shapes
        public int X { get; set; } // X coordinate of the shape's position
        public int Y { get; set; } // Y coordinate of the shape's position

        // Constructor
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to check if this shape overlaps with another shape
        public virtual bool Overlaps(Shape other)
        {
            // Implementation will be in derived classes
            return false;
        }
    }

    // Rectangle class derived from Shape
    public class Rectangle : Shape
    {
        // Additional properties specific to rectangles
        public int Width { get; set; }
        public int Height { get; set; }

        // Constructor
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        // Overridden method to check for overlap with another rectangle
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

        // Helper method to create a rectangle from user input
        static Rectangle CreateRectangle()
        {
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            return new Rectangle(x, y, width, height);
        }
    }
}