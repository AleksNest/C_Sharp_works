Console.WriteLine("Задача на вычисления max");
int x1 = 2;
int x2 = 5;
int x3 = 10;

int Max = x1;
if (x1 > Max) Max = x1;
if (x2 > Max) Max = x2;
if (x3 > Max) Max = x3;

Console.Write("максимум ="); 
Console.WriteLine(Max); 
