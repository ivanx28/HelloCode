﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лиза")
{
    Console.WriteLine("Ура это же ЛИЗА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}