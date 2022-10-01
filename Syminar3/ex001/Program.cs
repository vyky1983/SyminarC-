using static System.Console;
Clear();

Write("Введите номер --> ");
int rnd = new Random().Next(1,100);
int num = Convert.ToInt32(ReadLine ());
Write($"Ваш номер --> {num}");
string num1 = rnd<=5?" правельный":" неправельно";
WriteLine(num1);