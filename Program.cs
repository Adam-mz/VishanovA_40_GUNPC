// Логический (побитовый) калькулятор — задание по C#

Console.WriteLine("Enter first number:");
if (!int.TryParse(Console.ReadLine(), out int a))
{
    Console.WriteLine("Error! First value is incorrect.");
    return;
}

Console.WriteLine("Enter second number:");
if (!int.TryParse(Console.ReadLine(), out int b))
{
    Console.WriteLine("Error! Second value is incorrect.");
    return;
}

Console.WriteLine("Enter operator (&, | or ^):");
string op = Console.ReadLine();

int result;

switch (op)
{
    case "&":
        result = a & b;
        break;

    case "|":
        result = a | b;
        break;

    case "^":
        result = a ^ b;
        break;

    default:
        Console.WriteLine("Error! Operator must be &, | or ^.");
        return;
}

Console.WriteLine($"Decimal: {result}");
Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
Console.WriteLine($"Hex: {result:X}");
