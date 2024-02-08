

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Its Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("Its Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Its Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("Its Wendsday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Its Thursday!");
}
else if (weekDay == 5)
{ 
    Console.WriteLine("Its Friday!");
}
else if (weekDay == 6)
{
    Console.WriteLine("Its Saturday");
}
Console.WriteLine("Have a nice day!");




