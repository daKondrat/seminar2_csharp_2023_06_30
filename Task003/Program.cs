// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    System.Console.Write(message);    // Выводим в консоль приглашение для ввода
    string imputedStr = Console.ReadLine(); // Вводим стоку с консоли
    int number = Convert.ToInt32(imputedStr); // Преобразует строку в целое значение
    return number; // Возвращает из функции значение
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели");
    return false;
}

int weekDay = ReadInt("Введите численный день недели => ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        System.Console.WriteLine("Ура, выходной!");
    }
    else
    {
        System.Console.WriteLine("Эх, нужно работать");
    }
}


