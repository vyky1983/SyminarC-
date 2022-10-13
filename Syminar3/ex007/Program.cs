using static System.Console;

Clear();

WriteLine("1 стрелок : ");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("1 стрелок : ");
int num2 = Convert.ToInt32(ReadLine());
WriteLine($"1 стрелок не выбил {num2 - 1} банок");
Write($"2 стрелок не выбил {num1-1}  банок");