// Показать вторую цифру трёхзначного числа

Console.WriteLine("Ввеите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int second = n / 10 % 10;
    
    Console.WriteLine("Номер второго числа:" + " " + second);
}
else
    Console.WriteLine("Число не трехзначное. Ввеите трехзначное число: ");

