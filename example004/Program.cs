﻿Console.WriteLine("Задача на проверку имени Маша - регистр любой");
Console.WriteLine("введите имя пользователя!");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("ура это же Маша");
}
else
{
    Console.Write ("привет  ");
    Console.WriteLine (username);

}