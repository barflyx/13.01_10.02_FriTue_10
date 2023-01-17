// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
/*
Console.WriteLine("День недели:");
Console.WriteLine("1 - Понедельник");
Console.WriteLine("2 - Вторник");
Console.WriteLine("3 - Среда");
Console.WriteLine("4 - Четверг");
Console.WriteLine("5 - Пятница");
Console.WriteLine("6 - Суббота");
Console.WriteLine("7 - Воскресенье");
*/

Console.Write("Введите число: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Понедельник");
}
else if (day == "2")
{
    Console.WriteLine("Вторник");
}
else if (day == "3")
{
    Console.WriteLine("Среда");
}
else if (day == "4")
{
    Console.WriteLine("Четверг");
}
else if (day == "5")
{
    Console.WriteLine("Пятница");
}
else if (day == "6")
{
    Console.WriteLine("Суббота");
}
else if (day == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Не правильный ввод!");
}

/*
Алтернативный метод решения 

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine()) ;
switch (number)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
case 7:
Console.WriteLine("Воскресенье");
break;
default:
Console.WriteLine("Вы ввели не правильное число. Введите число от 1 до 7");
break;
}
*/