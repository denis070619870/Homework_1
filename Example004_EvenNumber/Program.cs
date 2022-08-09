// Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine());

if(userNumber % 2 ==0)
{
    Console.WriteLine(userNumber +" "+ "Является четным");
}
else
{
    Console.WriteLine(userNumber +" "+ "Не является четным");
}
