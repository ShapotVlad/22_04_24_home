//Задача 1: Напишите программу,
//которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

Console.WriteLine("ввод числа");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number%7;
int number2 = number%23;
int result = number1 + number2;

if (result == 0)
{
    Console.WriteLine("да,число является кратным 7 и 23");
}
else
{
    Console.WriteLine("нет,число не является кратным 7 и 23");
}

