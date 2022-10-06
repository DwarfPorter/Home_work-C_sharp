//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max;

Console.Write("1 число: " );
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("2 число: " );
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("3 число: " );
int c = Convert.ToInt32(Console.ReadLine());

max = a;

if (b > max)
{
   max = b; 
}

if (c > max)
{
   max = c; 
}

Console.Write ("Максимальное число " + max);
