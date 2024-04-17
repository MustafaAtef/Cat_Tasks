
namespace Task2 {
    public class Rectangle {
        public int Width { get; set; }
        public int Length { get; set; }

        public Rectangle() : this(0,0)
        {
        }
        public Rectangle(int w, int l)
        {
            Width = w;
            Length = l;
        }
        public int Area() => Width * Length;
        public int Perimeter() => 2 * (Width + Length);
    }
}
