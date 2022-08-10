// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 100);
int Max = 0;
int MaxNumber()
{
    int OneNumber = a / 10;
    int TwoNumber = a % 10;
    if (OneNumber > TwoNumber) Max = OneNumber;
        
    else Max = TwoNumber;

    return Max;
}
MaxNumber();
System.Console.WriteLine("В числе" + " " + a + " " + "наибольшая цифра" + " " + Max);