// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");

int a = int.Parse(Console.ReadLine());

int b = a % 100;

int c = b / 10;

Console.Write("Вторая цифра вашего числа это: ");
Console.Write(c);
