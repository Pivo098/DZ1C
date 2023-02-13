Console.WriteLine("Введите число > ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; i += 2) // += как я узнал это сочетание символов присваиваение и сложение (i = i + 2)
    Console.WriteLine(i);