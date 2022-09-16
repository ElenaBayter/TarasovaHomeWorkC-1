// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("add first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("add second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1>number2)
{
    Console.WriteLine("First number is max and second number is min");
}

else
{
    Console.WriteLine("First number is min and second number is max");
}