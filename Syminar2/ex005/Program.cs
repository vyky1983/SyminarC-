using static System.Console;

Clear();

WriteLine("Введите первое  число: ");
int num1 = int.Parse(ReadLine()!);
WriteLine(" Введите  второе: ");
int num2 = int.Parse(ReadLine()!);
if (num2 == 0)
{
    System.Console.WriteLine(" Ноль не является квадратом никокого числа ");
    return;
}

if (num2 > num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
double sqrt = Math.Sqrt(num1);
if (sqrt == num2)
{
    System.Console.WriteLine($"{num1} квадрат {num2}");
}
else
{
    System.Console.WriteLine($"{num1} не является квадратом {num2}");
}
