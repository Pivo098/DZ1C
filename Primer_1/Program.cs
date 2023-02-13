// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число > ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число > ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2)
{
    Console.WriteLine($"Число {userNumber1} больше числа {userNumber2}");
}
else
{
    Console.WriteLine($"Число {userNumber2} больше числа {userNumber1}");
}