using static System.Console;

Clear();
WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(ReadLine());

WriteLine("Введите третье число: ");
int numb3 = Convert.ToInt32(ReadLine());

// WriteLine(numb1>numb2?numb1:numb2);
int max = numb1 > numb2 ? numb1 : numb2;
WriteLine($"Максимальное число --> {max}");
int max1 = max > numb3 ? max : numb3;
WriteLine(max1);
