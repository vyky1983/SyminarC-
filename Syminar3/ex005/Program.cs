using static System.Console;

Clear();

/*Напишите прграмму которая принимает на вход число (N) и выдает таблицу квадратов числа
5 --> 1,4,9,16,25
2 --> 1,4,*/

Write("Ведите число: ");
int num = Convert.ToInt32(ReadLine());

for (int i = 1; i <= num; i++)
{
    int result = i * i;
    Write($"{result} ");
}
