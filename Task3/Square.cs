

namespace Task3 {
    public class Square : Shape {
        public int Width { get; set; }
        public Square() : this(0)
        {
            
        }
        public Square(int w)
        {
            Name = "Square";
            Width = w;
        }
        public override int CalculateArea() {
            return Width * Width;
        }
    }
}
