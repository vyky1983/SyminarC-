
// Напишите метод, который считает количесвто нулей в бинарном массиве

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int l = int.Parse(ReadLine()!);
int[] array = GetBinaryArray(l);
PrintArray(array);
WriteLine($"Количество нулей в массиве равно {ZeroCount(array)}");






int[] GetBinaryArray(int length)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < length-1; i++)
    {
        result[i] = rnd.Next(0,2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[ ");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]},");
    }
   Write("\b ");
    WriteLine("]");
}

int ZeroCount(int[] inArray)
{
    int result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i]==0) result++;
    }
    return result;
}