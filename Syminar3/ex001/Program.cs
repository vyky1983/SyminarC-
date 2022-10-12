using static System.Console;
Clear();

//Write(" Ведите число");
int rnd = new Random().Next(10,100+1);
WriteLine(rnd);
int a0 = rnd%10;
int a1 = rnd/10;
if(a0>a1)
{
 WriteLine($" Максимальное число = {a0} ");
}
else{
 WriteLine(a1);
}
//WriteLine(a0>a1?a0:a1);