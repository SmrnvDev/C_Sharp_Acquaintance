
/*
Многострочный комментарий
вау ваувау
*/

// Комментарий однострочный

// Напишите программу, которая на вход
// принимает два числа и проверяет
// является ли первое число квадратом второго
// a = 25, b = 5 => да
// a =2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int number = 9;
// int result = number * number;

// Console.ReadLine() - получить инфу из строчки
//  Console.Write("ВВедите число:");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(input + 1000);


Console.Write("Введите певрое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); 

if(firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да," + firstNumber + "является квадратом от числа " + secondNumber);
}
else //a не является квадратом от числа b
{
 Console.WriteLine("Нет," + firstNumber + "является квадратом от числа " + secondNumber);
}