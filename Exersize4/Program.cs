// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("add number1: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("add number2: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("add number3: ");
int number3 = int.Parse(Console.ReadLine());

int a = number1;

if (number2 > a)
{
    a = number2;
}

if (number3 > a)
{
    a = number3;
}
Console.WriteLine($"Maximal number is {a}");

