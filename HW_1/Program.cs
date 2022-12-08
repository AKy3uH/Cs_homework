Console.WriteLine("Введите 2 числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;
if (a==b)
{
    Console.Write("Вы ввели равные числа");
}
if (b>max)
{
    max = b;
    Console.WriteLine("число " + b + " большее");
    Console.Write("число " + a + " меньшее");
}
else
{
    Console.WriteLine("число " + a + " большее");
    Console.Write("число " + b + " меньшее");
}