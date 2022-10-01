using static System.Console;
Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());
WriteLine($" Ваше число {num} ");
// if(num%2==0){
//  WriteLine("Четное");
// }
// else {
//  WriteLine(" Число нечетное");
// }
// string answer = num%2==0?"Четное" : "Нечетное";
// WriteLine(answer);
WriteLine(num%2==0?" Четное ": "Нечетное" );