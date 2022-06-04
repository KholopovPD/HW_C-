int number = new Random().Next(10, 99);

Console.Write("Случайное число: ");

Console.WriteLine(number);

int a = number / 10;

Console.Write("Первая цифра числа: ");

Console.WriteLine(a);

int b = number % 10;

Console.Write("Вторая цифра числа: ");

Console.WriteLine(b);

if (a > b)
{
    Console.Write("Наибольшая цифра случайного числа: ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Наибольшая цифра случайного числа: ");
    Console.WriteLine(b);
}