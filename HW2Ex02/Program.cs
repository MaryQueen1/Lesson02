// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Задача 13");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    string stringNumber = Convert.ToString(number);
    Console.WriteLine("Третья цифра заданного числа -> " + stringNumber[2]);
}

else
{
    Console.Write("Третьей цифры нет");
}