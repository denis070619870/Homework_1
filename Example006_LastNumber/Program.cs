// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Ввеите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int result = n % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное. Ввеите трехзначное число: ");
}