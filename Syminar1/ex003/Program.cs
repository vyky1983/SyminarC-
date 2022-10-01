using static System.Console;
Clear();
Write("введите число --> ");
int num = Convert.ToInt32(ReadLine());
if (num == 1)
{
 WriteLine("Понтдельник");
}
if (num == 2)
{
 WriteLine("Вторник");
}
if (num == 3)
{
 WriteLine("Среда");
}
if (num == 4)
{
 WriteLine("Черверг");
}
if (num == 5)
{
 WriteLine("Пятница");
}
if (num == 6)
{
 WriteLine("Субота");
}
if (num == 7)
{
 WriteLine("Воскресения");
}
if (num < 1 || num > 7)
{
 WriteLine($"  Данное число --> {num} не совподает с днем недели ");
}