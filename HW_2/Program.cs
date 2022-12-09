//принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число от 100 до 999:");
bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if(isParsed == false)
    {
        Console.WriteLine("Нужны числа!");
    }
}

int newNumber = number / 10 % 10;

Console.WriteLine("Вторая цифра " + newNumber);

//выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool isParsed = false;
// int number = 0;
// while (isParsed == false)
// {
//     isParsed = int.TryParse(Console.ReadLine(), out number);
//     if(isParsed == false)
//     {
//         Console.WriteLine("Пиши числа!");
//     }
// }
