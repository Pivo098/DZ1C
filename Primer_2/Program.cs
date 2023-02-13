// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// // 22 3 9 -> 22

Console.WriteLine("Введите первое число > ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число > ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число > ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());

int max = userNumber1;
if (max < userNumber2 ) max = userNumber2;
if (max < userNumber3) max = userNumber3;

Console.WriteLine($"Максимальное число равно {max}");



