// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Для проверки максимального из трёх чисел ");
Console.Write("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = int.Parse (Console.ReadLine());
int max = 0;

if(number1 > number2)
{
    max = number1;
    if(max > number3)
    {
        Console.WriteLine("Максимальное число: " + max);
    }
    else 
    {
        max = number3;
        Console.Write("Максимальное число: " + max);
    }
}
else if(number2 > number3)
{
    max = number2;
    Console.Write("Максимальное число: " + max);
}
else
{
    max = number3;
    Console.Write("Максимальное число: " + max);
}                             