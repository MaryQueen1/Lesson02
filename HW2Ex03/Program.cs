// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Задача 15");

Console.Write("Enter your number 1-7");
int a;
do Console.Write(" (a) = ");
while (!int.TryParse(Console.ReadLine(), out a));

if(a == 6 || a == 7)
{
    Console.WriteLine("Yes");
}

else if(a < 1 || a > 7)
{
    Console.WriteLine("Enter number 1-7!");
}

else
{
    Console.Write("No");
}

