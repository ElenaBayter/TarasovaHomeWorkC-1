// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Write a number N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;
while (a <= n)
{
    Console.Write($"{a} ");
    a++;
}
