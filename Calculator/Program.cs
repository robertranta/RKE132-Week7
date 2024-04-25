Console.WriteLine("Enter the operation (+/-):");
char useroperator = char.Parse(Console.ReadLine());


Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (useroperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-': 
        Subraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}



static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}


