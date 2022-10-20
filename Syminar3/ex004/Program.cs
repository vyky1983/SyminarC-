using static System.Console;
Clear();

WriteLine("Введите число");
int num =Convert.ToInt32(ReadLine());

if (num==0)
{
 WriteLine("На ноль делить нельзя");
 return;
}
int div1 = num%7;
int div2 = num%23;
if(div1==0||div2==0)
{
 WriteLine($"{num} кратен 7 и 23");
}
else 
{
 System.Console.WriteLine($"{num} не кратен 7 и 23");
}