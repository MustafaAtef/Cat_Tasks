

using Task3;

List<Shape> shapes = new() {
    new Rectangle(5,6),
    new Square(10),
    new Rectangle(4,10)
};

CalcAreas(shapes);

void CalcAreas(List<Shape> s) {

    foreach (var shape in s) {
        Console.WriteLine($"Area of {shape.Name} is {shape.CalculateArea()}");
    }
}