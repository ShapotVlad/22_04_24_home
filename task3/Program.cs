// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

Console.WriteLine("ввод двухзначного числа от 10 до 99");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstdigital = num / 10;
    int seconddigital = num % 10;

    if (firstdigital > seconddigital)
    {
        Console.WriteLine($"вывод результата = {firstdigital}");
    }
    else if (firstdigital == seconddigital)
    {
        Console.WriteLine($"вывод результата = {firstdigital}");
    }
    else
    {
        Console.WriteLine($"вывод результата = {seconddigital}");
    }
}
else
{
    Console.WriteLine("Ошибка! Число не вотрезке от 10 до 99.");
}
