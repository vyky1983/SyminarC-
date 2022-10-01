using static System.Console;
Clear();
Write($"Введите число --> ");
int num2 = Convert.ToInt32(ReadLine());
int num1 = int.Parse(ReadLine()!);
int sqr1 = num1 * num2;
int sqr2 = Convert.ToInt32(Math.Pow(num2, 2));
WriteLine($"квадрат числа {num1} = {sqr1}");
WriteLine($"квадрат числа {num2} = {sqr2}");
