// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int b = 1;
Console.Write( "Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

while(b <= a)
{
    while (b % 2 == 0)
    {
        Console.Write(b + " ");
        b++;
    }
  b++;
}


