// Console.WriteLine("Введите 2 числа: ");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int max = a;
// if (a==b)
// {
//     Console.Write("Вы ввели равные числа");
// }
// if (b>max)
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

Console.WriteLine("Введите 3 числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
// if (a == b | b == c | a == c)
// {
//     Console.Write("Вы ввели равные числа");
// }
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("число " + max + " наибольшее");