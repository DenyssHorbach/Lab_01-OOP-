namespace CSharp
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(double length, double width, double x = 0, double y = 0)
        {
            Length = length;
            Width = width;
            X = x;
            Y = y;
        }

        public (double, double)[] GetVertices()
        {
            return new (double, double)[]
            {
                (X, Y),
                (X, Y + Width),
                (X + Length, Y + Width),
                (X + Length, Y)
            };
        }

        public double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetLength()
        {
            return Length;
        }

        public double GetWidth()
        {
            return Width;           
        }

        ~Rectangle()
        {
            
        }
    }
}