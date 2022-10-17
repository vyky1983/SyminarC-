using static System.Console;

Clear();

/* создать программу которая заполняет масив 0 и 1 8 элемментов*/

System.Console.WriteLine("Введите размер масива ");
int size = Convert.ToInt32(ReadLine());
int[] array = GetArr(size);
PrintArr(array);
System.Console.WriteLine();
System.Console.WriteLine($"Number of zero {countZeros(array)}");
System.Console.WriteLine("Input number digit --> ");
int digit = Convert.ToInt32(ReadLine());
System.Console.WriteLine($"Number of Dogit {digit}: {CountDigits(array, digit)}");

int[] GetArr(int Length)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] inArr)
{
    Write("[");
    for (int i = 0; i < inArr.Length - 1; i++)
    {
        Write($"{inArr[i]},");
    }
    Write($"{inArr[inArr.Length - 1]}]");
}

int countZeros(int[] inArr)
{
    int result = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i] == 0)
        {
            result += 1;
        }
    }
    return result;
}

int CountDigits(int[] inArr, int num1)
{
    int result = 0;

    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i] == num1)
        {
            result += 1;
        }
    }
    return result;
}
