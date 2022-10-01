using static System.Console;

Clear();

WriteLine("Введите число номер1 --> ");
int num1 = int.Parse(ReadLine()!);
WriteLine("Введите число номер2 --> ");
int num2 = int.Parse(ReadLine()!);
int tem = num1;
num1 = num2;
num2 = tem;

if (num2 == 0)
{
    Console.WriteLine("на 0 не делится");
    return;
}

double div = num1 % num2;
if (div == 0)
{
    WriteLine($"{num2} кратно {num1}");
}
else
{
    WriteLine($"Остаток от деления {num1} na {num2}: {div}");
}

// if (num1 % num2 == 0)
// {
//     WriteLine("Число кратное");
// }
// else
// {
//     WriteLine($"остаток от деления равен {num1 % num2} ");
// }
