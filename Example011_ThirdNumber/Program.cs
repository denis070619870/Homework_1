﻿// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число, чтобы оно было более трехзначного: ");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    Console.WriteLine("Третьей цифрой числа:"+ " " + n + " " + "будет"+ " " + n % 10);
}
else if (n > 1000 && n < 10000)
{
    Console.WriteLine("Третьей цифрой числа:"+ " " + n + " " + "будет"+ " " + n / 10 % 10);
}
else if (n > 10000 && n < 100000)
{
    Console.WriteLine("Третьей цифрой числа:"+ " " + n + " " + "будет"+ " " + n / 100 % 10);
}
else
{
    Console.WriteLine("Не трехзначное число");
}