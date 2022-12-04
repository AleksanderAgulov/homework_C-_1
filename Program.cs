//Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input sekond number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("num1 = max");
    Console.WriteLine("num2 = min");
}
else
{
    Console.WriteLine("num2 = max");
    Console.WriteLine("num1 = min");
}
*/

//Задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input thurd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
    {
        Console.Write(num1);
    }
}
if(num2 > num1)
{
    if(num2 > num3)
    {
        Console.Write(num2);
    }
}
if(num3 > num1)
{
    if(num3 > num2)
    {
        Console.Write(num3);
    }
}
*/
// Задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write("number - четное");
}
else
{
    Console.Write("number - не четное");
}
*/

//Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current ++;
} 
*/