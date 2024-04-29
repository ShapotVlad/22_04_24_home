// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//  в которой находится эта точка.

Console.WriteLine("ввод первого числа");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ввод второго числа");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0 && num2 > 0)
{
    Console.WriteLine("точка находиться в 1 координатной плоскости");
}
else if (num1 < 0 && num2 > 0)
{
    Console.WriteLine("точка находиться в 2 координатной плоскости");
}
else if (num1 < 0 && num2 < 0)
{
    Console.WriteLine("точка находиться в 3 координатной плоскости");
}
else if (num1 > 0 && num2 < 0)
{
    Console.WriteLine("точка находиться в 4 координатной плоскости");
}
else
{
    Console.WriteLine("координаты x или y равны 0");
}
