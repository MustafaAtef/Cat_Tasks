

namespace Task3 {
    public class Rectangle : Shape {
        public int Width { get; set; }
        public int Length { get; set; }
        public Rectangle() : this(0, 0)
        {
            
        }
        public Rectangle(int w, int l)
        {
            Name = "Rectangle";
            Width = w;
            Length = l;
        }
        public override int CalculateArea() {
            return Width * Length;
        }
    }
}
