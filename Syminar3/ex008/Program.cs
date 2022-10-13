using static System.Console;

Clear();

System.Console.WriteLine("Введитем количество сделанных корабликов");
int num = Convert.ToInt32(ReadLine());
var ship = num / 6;
WriteLine($"Девочка сделала {ship * 4} корабликов ");
WriteLine($"Каждый мальчик сделал по {ship} корабликов ");
