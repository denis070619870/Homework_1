﻿// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = new Random().Next(10, 21);
Console.Write(a);

Console.WriteLine("Ввеите число, на которое нужно проверить кратность выбранного числа: ");
int b = int.Parse(Console.ReadLine());

//int Balance = a % b;
//return Balance;

if (a % b == 0)
{
    Console.Write("Число: " + " " + a + " " + "Кратно числу" + " " + b);
}
else
{
     Console.Write("Число: " + " " + a + " " + "не кратно числу" +" " + b + "." +" " + "Остаток от деления: "); // + " " + Balance
}