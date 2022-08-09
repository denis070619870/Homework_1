// Найти максимальное из трех чисел

int a = new Random().Next(1, 10);
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);
int c = new Random().Next(1, 10);
Console.WriteLine(c);

if ( a > b && a > c)
{
    Console.WriteLine(a + " " + "Наибольшее число");
}
if ( b > a && b > c)
{
    Console.WriteLine(b + " " + "Наибольшее число");
}
else
{
    Console.WriteLine(c + " " + "Наибольшее число");
}

