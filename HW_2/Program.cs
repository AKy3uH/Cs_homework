//принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите число от 100 до 999:");
// bool isParsed = false;
// int number = 0;
// while (isParsed == false)
// {
//     isParsed = int.TryParse(Console.ReadLine(), out number);
//     if (isParsed == false)
//     {
//         Console.WriteLine("Нужны числа!");
//     }
// }
// if (number < 1000 & number > 99)
// {
//     int newNumber = number / 10 % 10;
//     Console.WriteLine("Вторая цифра " + newNumber);
// }
// else
// {
//     Console.WriteLine("число должно быть 3-значным");
// }


//выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

// Console.WriteLine("Введите число больше 99:");
// bool isParsed = false;
// int number = 0;
// int thirdDigit = 0;
// while (isParsed == false)
// {
//     isParsed = int.TryParse(Console.ReadLine(), out number);
//     if (isParsed == false)
//     {
//         Console.WriteLine("Нужны числа!");
//     }
// }
// if (number > 99)
// {
//     while (number>999)
//     {
//         number = number / 10;
//     }
//     thirdDigit = number % 10;
//     Console.WriteLine("третья цифра введенного числа " + thirdDigit);
// }
// else
// {
//     Console.WriteLine("нужно число минимум 3-значное");
// }


//принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите номер дня недели (1-7):");
// bool isParsed = false;
// int number = 0;
// while (isParsed == false)
// {
//     isParsed = int.TryParse(Console.ReadLine(), out number);
//     if (isParsed == false)
//     {
//         Console.WriteLine("Пиши числа!");
//     }
// }
// if (number > 0 & number < 8)
// {
//     if (number == 6 | number == 7)
//     {
//         Console.WriteLine("Ура, выходной!");
//     }
//     else
//     {
//         Console.WriteLine("будни, марш работать...");
//     }
// }
// else
// {
//     Console.WriteLine("в неделе 7 дней!");
// }