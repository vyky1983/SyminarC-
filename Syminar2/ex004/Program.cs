using static System.Console;

Clear();
WriteLine("Введите число: ");
int num1 = int.Parse(ReadLine()!);

if (num1 == 0)
{
    WriteLine("Просто ");
    return;
}
int div1 = num1 % 7;
int div2 = num1 % 23;

// if (div1 == 0 && div2 == 0)
// {
//     WriteLine($"{num1} кратно 7 и 23");
// }
// else
// {
//     WriteLine($" Число {num1} не кратно 7 и 23");
// }
// string answer =num1%7==0&&num1%23==0?"Кратное":"Некратное";
// WriteLine(answer);
WriteLine(num1%7==0&&num1%23==0? /*Тернарный оператор*/"Кратное":"Некратное");

