﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "люба")
{
   Console.WriteLine("Ура, это же Люба!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}