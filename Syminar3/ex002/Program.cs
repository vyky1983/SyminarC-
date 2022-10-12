using static System.Console;
Clear();

int number  = new Random().Next(100,1000);
int a0=number%10;
//int a1=number/10;
int a2=number/100;
int result=a2*10+a0;
WriteLine(result);
 //WriteLine($"{a2}{a0}");