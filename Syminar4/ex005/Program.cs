using static System.Console;
Clear();
System.Console.WriteLine("Введите номер: ");
int num = Convert.ToInt32(ReadLine());
int fact =GetFactorial(num);
System.Console.WriteLine(fact);

int GetFactorial(int num1)
{
 int result=1;
for (int i = 1; i <= num1; i++)
{
result*=i;

}
return result;
}

// int GetFactor(int number){
// int result = 1;
// for(int i = 1; i <= number; i++){
// result *= i;
// }
// return result;
// }