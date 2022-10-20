using static System.Console;

Clear();

/*Hапишите прграмму, каторая реализуетметод который принимает число "A" и возвращает сумму чисел от 1 до  "A" */

Write("Введите номер A: ");
int num1 = Convert.ToInt32(ReadLine());

int sum = GetSum(num1);
WriteLine($"Сумма чисел от 1 до А = {sum}");

int GetSum(int numA)
{
    int result = 0;
    while(numA>0)
    {
     result+=numA;
     numA--;
    }
    return result;
}
