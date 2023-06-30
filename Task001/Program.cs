// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string message)
{
    System.Console.Write(message);    // Выводим в консоль приглашение для ввода
    string imputedStr = Console.ReadLine(); // Вводим стоку с консоли
    int number = Convert.ToInt32(imputedStr); // Преобразует строку в целое значение
    return number; // Возвращает из функции значение
}
int num = ReadInt("Введите трёхзначное число => ");
if (num < 100 || num >= 1000)
{
    System.Console.WriteLine("Вы ввели не трёхзначное число");
    return;
}
System.Console.WriteLine($"Вы ввели число {num}");
int result = num / 10 % 10;
System.Console.WriteLine($"Вторая цифра введённого числа равна {result}");