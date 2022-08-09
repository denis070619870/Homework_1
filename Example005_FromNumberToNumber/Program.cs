// Показать числа от -N до N

Console.WriteLine("Введите число от которого будт показаны все числа: ");
int userNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до которого будт показаны все числа: ");
int userNumber2 = int.Parse(Console.ReadLine());

int count = userNumber1;

Console.WriteLine(" ");
while(count <= userNumber2)
{
    Console.WriteLine(count + " ");
    count ++;
}

Console.WriteLine(" ");

//Запись с проверкой
//Куда проставить break; чтобы не запустить неуправляемый цикл?


//Console.WriteLine(" ");
//while(count <= userNumber2)
//{
//   if(userNumber1 < userNumber2);
//        {
//            Console.WriteLine(count + " ");
//          count ++;
//        }
//  else
//  {
//    Console.WriteLine("Первое введенное значение должно быть меньше второго");
//  }
//}
//
//Console.WriteLine(" ");
