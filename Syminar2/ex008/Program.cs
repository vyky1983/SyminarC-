using static System.Console;

Clear();

System.Console.WriteLine("Введите число --> ");
int number = Convert.ToInt32(ReadLine());
string result = string.Empty;

while (number > 0)
{
    result += number % 10;
    number /= 10;
}
int newnumber = Convert.ToInt32(result);
WriteLine($" Ваш номер --> {newnumber}");

int num = int.Parse(result);

 