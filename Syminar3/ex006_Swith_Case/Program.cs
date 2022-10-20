using static System.Console;

Clear();

/*Напишите программу которая будет выдовать дня недели по задоному номеру*/

Write(" введите номер соответствующему дню недели --> ");
int num_day = Convert.ToInt32(ReadLine());

switch (num_day)
{
    case 1:
    {
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        System.Console.WriteLine("Среда");
        break;
    }
    case 4:
    {
        System.Console.WriteLine("Четверг");
        break;
    }
    case 5:
    {
        System.Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        System.Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        System.Console.WriteLine("Воскресение");
        break;
    }
    default:
    {
        System.Console.WriteLine("Error");
        break;
    }
}
