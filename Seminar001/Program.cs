Console.WriteLine("программа проверяет является ли первое число квадратом второго");
Console.WriteLine ("введите число 1");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите число 2");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1*Number1 == Number2) 
{
    Console.WriteLine ("Да является квадратом");
}
else
{
Console.WriteLine ("Нет, не  является квадратом");
}

Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("программа для вывода дня недели по номеру");
Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
switch(num)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("вторник");
break;
case 3:
Console.WriteLine("среда");
break;
case 4:
Console.WriteLine("четверг");
break;
case 5:
Console.WriteLine("пятница");
break;
case 6:
Console.WriteLine("суббота");
break;
case 7:
Console.WriteLine("воскресенье");
break;
default:
Console.WriteLine("ввели неправильное число");
break;
}

Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("ввод N - вывод целых чисел от -N до N ");
Console.WriteLine("введите число целое  N ");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
for (int i = -1*a; i<=a; i++)
{
    Console.WriteLine(i);
}
