
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0-6

switch(weekDay) //väärtus mida kontrollitakse.
{
    case 0: //case 0: == if(weekDay == 0)
        Console.WriteLine("Its sunday");
        break;
    case 1:
        Console.WriteLine("Its monday");
        break;
    case 2:
        Console.WriteLine("Its tuesday");
        break;
    case 3:
        Console.WriteLine("Its wednesday");
        break;
    case 4:
        Console.WriteLine("Its thursday");
        break;
    case 5:
        Console.WriteLine("Its friday");
        break;
    case 6:
        Console.WriteLine("Its saturday");
        break;
        default:
        Console.WriteLine("Oops! Your calender must be broken!");
        break;
}


Console.WriteLine("Have a nice day!");