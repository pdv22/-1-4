// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max;

if (a > b && a > c)
{
max = a;
Console.WriteLine("Первое число - максимальное");
}
else if (b > a && b > c)
{
max = b;
Console.WriteLine("Второе число - максимальное");
}
else
{
max = c;
Console.WriteLine("Третье число - максимальное");
}
Console.ReadKey();