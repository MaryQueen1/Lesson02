// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int value = new Random().Next(10, 100);
// int a = value / 10;
// int b = value % 10;
// Console.WriteLine(value);

// if(a > b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }

// void Ex01() 
// {
//     int value = new Random().Next(10, 100);
//     int a = value / 10;
//     int b = value % 10;
//     Console.WriteLine(value);

//     if(a > b)
//     {
//         Console.WriteLine(a);
//     }
//     else
//     {
//         Console.WriteLine(b);
//     }
// }

// int Ex02() 
// {
//     int value = new Random().Next(10, 100);
//     int a = value / 10;
//     int b = value % 10;
//     Console.WriteLine(value);

//     if(a > b)
//     {
//         return (a);
//     }
//     else
//     {
//         return (b);
//     }
// }
// Console.WriteLine(Ex02()); // вызов метода

// string Ex03() 
// {
//     string res = String.Empty;
//     int value = new Random().Next(10, 100);
//     int a = value / 10;
//     int b = value % 10;
//     res = Convert.ToString(value);

//     if(a > b)
//     {
//         res = res + "  " + Convert.ToString(a);
//     }
//     else
//     {
//         res = res + "  " + Convert.ToString(b);
//     }
//     return res;
// }
// System.Console.WriteLine(Ex03()); 

int Ex04(int value) 
{
    int a = value / 10;
    int b = value % 10;
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
System.Console.WriteLine();
int num = new Random().Next(10, 100);
Console.WriteLine(num);

System.Console.WriteLine(Ex04(num)); 