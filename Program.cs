// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("ВВедите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int secondNum = (num/10)%10;

// Console.WriteLine(secondNum);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int num2 = num1;

// if (num1/100 != 0)
// {


//        while ((num2>1000)||(num2< -1000))
//      {
//         num2 = num2/10;
//      }
//          num2 = num2%10;
//          if (num2>0)
//          {
//              Console.WriteLine(num2);
//          }
//          else
//          {
//             num2 =num2*-1;
//             Console.WriteLine(num2);
//          }
         
// }

// else
// {
//     Console.WriteLine("нет третьей цифры");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if ((num == 6)||(num == 7))
{
    Console.WriteLine("Выходной");
}
else if ((num<1)||(num>7))
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
Console.WriteLine("Рабочий день");
}