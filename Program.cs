/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


int max = 0;
int min = 0;

Console.Write("введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
max = firstNumber;
min = secondNumber;
}

else
{
    max = secondNumber;
    min = firstNumber;
}

Console.WriteLine($"max = {max} и min = {min}");


/*

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/


int max = 0;

Console.Write("введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число: ");
int ThreeNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > max)
{
    max = FirstNumber;
}
if (secondNumber > max)
{
    max = secondNumber;
}
if (ThreeNumber > max)
{
    max = ThreeNumber;
}

Console.WriteLine($"max = {max}");


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/


Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if (remDiv == 0)
{
    Console.WriteLine("да");
}

else 
{
    Console.WriteLine("нет");
}



/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if (number > 1)
{
    while (evenNumber <= number)
    {
       Console.WriteLine(evenNumber + " ");
       evenNumber = evenNumber + 2;
    }
}