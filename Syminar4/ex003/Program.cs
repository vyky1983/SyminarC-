using static System.Console;

Clear();

System.Console.WriteLine("Введите количество элементов в масиве");
int num = Convert.ToInt32(ReadLine());
int[] arraynum2 = new int[num];
ArrayNumber(arraynum2);


void ArrayNumber(int[] arraynum)
{
    for (int i = 0; i < arraynum.Length; i++)
    {
        int rnd = new Random().Next(10, 100);
        arraynum[i] = rnd;
        Write($"{arraynum[i]} ");
    }
}

