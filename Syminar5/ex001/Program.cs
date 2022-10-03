using static System.Console;

Clear();

/**Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]*/

WriteLine(" Введите размер масива, мин и макс через пробел:");
string[] parametres = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // считати 
WriteLine(parametres.Length);



int[] GetArray(int size, int minvalue, int maxValue)
{
 int[] res;
}
