


static void Calculator(int x, int y, MathOperation operation) =>
    Console.WriteLine($"The result of the operation {operation(x,y)}");


Calculator(10, 20, Addition);
Calculator(40, 20, Subtraction);
Calculator(40, 20, Multiplication);
Calculator(40, 20, Division);




static int Addition(int x, int y) => x + y;
static int Subtraction(int x, int y) => x - y;
static int Multiplication(int x, int y) => x * y;
static int Division(int x, int y) => x / y;


delegate int MathOperation(int op1, int op2);


