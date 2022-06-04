//Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());

int a = number / 100; //первое число

int b = number % 100;

int c = b / 10; //второе число

int d = number % 10; //третье число

Console.Write("первое число: ");
Console.WriteLine(a);

Console.Write("второе число: ");
Console.WriteLine(c);

Console.Write("третье число: ");
Console.WriteLine(d);

Console.Write("Новое число: ");
Console.Write(a);Console.Write(d); //скорее всего так не правильно делать, но как сделать корректно на семинаре не нашел