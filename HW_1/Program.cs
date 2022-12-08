// //на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите 2 числа: ");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int max = a;
// if (a == b)
// {
//     Console.Write("Вы ввели равные числа");
// }
// if (b > max)
// {
//     max = b;
//     Console.WriteLine("число " + b + " большее");
//     Console.Write("число " + a + " меньшее");
// }
// else
// {
//     Console.WriteLine("число " + a + " большее");
//     Console.Write("число " + b + " меньшее");
// }


// //принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите 3 числа: ");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int max = a;
// // if (a == b | b == c | a == c)
// // {
// //     Console.Write("Вы ввели равные числа");
// // }
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine("число " + max + " наибольшее");


// //на вход принимает число и выдаёт, является ли число чётным.

// Console.WriteLine("Введите число:");
// int a = int.Parse(Console.ReadLine());
// a = a % 2;
// if (a == 0)
// {
//     Console.WriteLine("Вы ввели чётное число");
// }
// else
// {
//     Console.WriteLine("Вы ввели НЕчётное число");
// }


// //на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число (больше 2):");
// int N = int.Parse(Console.ReadLine());
// if (N > 2)
// {
//     for (int num = 2; num < N; num += 2)
//     {
//         Console.Write(" " + num);
//     }
// }
// else
// {
//     Console.Write("Вы ввели число 2 или меньше.");
// }