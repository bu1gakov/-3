// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    Console.Write(message);
    string Value = Console.ReadLine();
    int result = Console.ToInt32(value);
    return result;
}

bool isWeekend(int weekDay)
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
    Console.WriteLine("Это не день недели! ");
    return false;
}

int weekDay = Prompt("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (isWeekend(weekDay))
    {
        Console.WriteLine("Сегодня выходной");
    }
    else
    {
        Console.WriteLine("Вставай на работу");
    }
}