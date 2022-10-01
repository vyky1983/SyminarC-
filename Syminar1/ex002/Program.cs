using static System.Console;
Clear();
Write($"Введите число --> ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = int.Parse(ReadLine()!);
if(num2*num2 == num1){
 WriteLine($"Число {num1}  является квадратом {num2} ");
}
else{
 WriteLine($"Число {num1} не является квадратом {num2} ");
}
