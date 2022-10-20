// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите M - кол-во символов : ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 1; i <= m; i++)
{
    Console.Write($"Введите число №{i}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0) count++;
}
Console.WriteLine($"Чисел больше 0: {count}");