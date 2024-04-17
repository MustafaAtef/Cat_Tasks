using Task2;


Console.Write("Enter the number of rectangle you want to create: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    Console.Write($"Enter width of Rectangle {i}: ");
    int w = int.Parse(Console.ReadLine());
    Console.Write($"Enter length of Rectangle {i}: ");
    int l = int.Parse(Console.ReadLine());
    Rectangle r = new(w, l);
    Console.WriteLine($"Area and perimeter of this rectangle: {r.Area()}, {r.Perimeter()}");
    Console.WriteLine("----------------------------");
}