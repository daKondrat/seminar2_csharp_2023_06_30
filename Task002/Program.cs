// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string message)
{
    System.Console.Write(message);    // Выводим в консоль приглашение для ввода
    string imputedStr = Console.ReadLine(); // Вводим стоку с консоли
    int number = Convert.ToInt32(imputedStr); // Преобразует строку в целое значение
    return number; // Возвращает из функции значение
}

int CheckNumbers (int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

bool ValidateDigits(int num)
{
    if (num < 100)
    {
        System.Console.WriteLine("В числе нет третьей цифры");
        return false; // Проверка не прошла
    }
    return true; // Проверка прошла успешно
}

int num = ReadInt("Введите число => ");
if (ValidateDigits(num))
{
System.Console.WriteLine(CheckNumbers(num));
}