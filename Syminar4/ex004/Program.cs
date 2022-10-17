using static System.Console;

Clear();

/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5*/

WriteLine("Введите число ");
int num = Convert.ToInt32(ReadLine());
int res = GetLen(num);
System.Console.WriteLine(res);

int GetLen(int num1)
{
    int result1 = 0;
    while (num1 > 0)
    {
        num1 /= 10;
        result1++;
    }
    return result1;
}

// int GetLen(int num1)
// {
//     int result1 = 0;
//     for (int i = 0; i <= num1; i++)
//     {
//      num1/=10;
//      result1++;
     
//     }
//     return result1;
// }

