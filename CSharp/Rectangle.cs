namespace CSharp
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
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