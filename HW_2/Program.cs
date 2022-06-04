//Найти максимальное из трех чисел

Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if  (a > max) max = a;
if  (b > max) max = b;
if  (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);