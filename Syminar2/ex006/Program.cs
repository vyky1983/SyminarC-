/* Введите случайное трехзначное число и выводите в обратном порядке */
using static System.Console;

Clear();

int rnd = new Random().Next(100, 1000);
WriteLine($" Вот ваше число --> {rnd} ");

int num1 = rnd % 10;
System.Console.WriteLine(num1);
int num2 = rnd / 10 % 10;
System.Console.WriteLine(num2);
int num3 = rnd / 100;
System.Console.WriteLine(num3);
System.Console.WriteLine($" Вот ваше число в перевернутом состоянии --> {num1}{num2}{num3}");
