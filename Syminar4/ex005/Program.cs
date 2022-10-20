using static System.Console;

Clear();

/* создать программу которая заполняет масив 0 и 1 8 элемментов*/
//System.Console.WriteLine();
System.Console.WriteLine("Введите размер масива ");
int size = Convert.ToInt32(ReadLine());
int[] array =GetArr(size);
PrintArr(array);

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
 for (int i = 0; i < inArr.Length-1; i++)
 {
 Write($"{inArr[i]},");
 }
Write($"{inArr[inArr.Length-1]}]");
}