
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string @operator = Console.ReadLine();

switch (@operator)
{
    case "+":
        double addition = num1 + num2;
        Console.WriteLine($"{num1} {@operator} {num2} = {addition:F2}");
        break;
    
    case "-":
        double subtraction = num1 - num2;
        Console.WriteLine($"{num1} {@operator} {num2} = {subtraction:F2}");
        break;

    case "*":
        double multiplication = num1 * num2;
        Console.WriteLine($"{num1} {@operator} {num2} = {multiplication:F2}");
        break;

    case "/":
        double division = num1 / num2;
        Console.WriteLine($"{num1} {@operator} {num2} = {division:F2}");
        break;

    default:
        break;
}
