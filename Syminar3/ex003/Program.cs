using static System.Console;

Clear();

WriteLine("Введите первое число");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int num2 = Convert.ToInt32(ReadLine());

if(num2>num1)
{
 int temp =num1; /*Меняем местами переменные*/
 num1=num2;
 num2=temp;
}

if (num2 == 0)
{
    WriteLine("На ноль делить нельзя");
    return;
}
int div = num1 % num2;
    if (div == 0)
    {
        WriteLine($"{num1} кратно {num2}");
    }
    else
    {
        WriteLine($"Остаток от деления {num1} на {num2}: {div} ");
    }

