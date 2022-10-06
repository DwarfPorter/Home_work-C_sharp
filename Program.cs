// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("Max: " + n1);
    Console.WriteLine("Min: " + n2);
}
else
{
    Console.WriteLine("Max: " + n2);
    Console.WriteLine("Min: " + n1);
}
