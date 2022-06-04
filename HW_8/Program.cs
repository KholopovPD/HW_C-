// Выяснить, кратно ли число заданному, если нет, вывести остаток.

double number = new Random().Next(1, 100);

Console.Write("Случайное число: ");

Console.WriteLine(number);

Console.Write("Введите делитель ");

double a = double.Parse(Console.ReadLine());

double b = number / a;

double c = b % 1;

if(c == 0)
{
    Console.Write("Случайное число кратно делителю ");
    Console.Write(b);
    Console.Write(" раз(а)");
}
else
{
    Console.Write("Случайное число не кратно делителю, остаток = ");
    Console.Write(c);
}