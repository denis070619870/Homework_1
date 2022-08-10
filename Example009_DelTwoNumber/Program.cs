// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Ввеите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int last = n % 10;
    int first = n / 100;
    int result = first * 10 + last;
    Console.WriteLine("Номер без второго числа:" + " " + result);
}
else
{
    Console.WriteLine("Число не трехзначное. Ввеите трехзначное число: ");
}
