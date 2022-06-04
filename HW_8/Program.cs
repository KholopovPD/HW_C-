// Выяснить, кратно ли число заданному, если нет, вывести остаток.

double number = new Random().Next(1, 101);

Console.Write("Случайное число: ");

Console.WriteLine(number);

Console.Write("Введите делитель ");

double a = double.Parse(Console.ReadLine());

double b = number / a;

Console.Write(b);
