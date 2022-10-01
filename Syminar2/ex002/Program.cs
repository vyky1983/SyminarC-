// Random rnd = new Random(); /*Создаем отдельный рандом*/
// int num = rnd.Next(10, 158);

using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
WriteLine(number);

int a0 = number%10;
//int a1 = number/10;
int a2 = number/100;

int result = a2*10+a0;
WriteLine(result);
