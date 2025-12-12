

Console.WriteLine("=== Задание 1: Первые 10 чисел Фибоначчи ===");

int[] fib = new int[10];
   fib[0] = 0;
   fib[1] = 1;
for (int i = 2; i<fib.Length;i++)
    fib[i] = fib[i-1] + fib[i-2];
Console.WriteLine("Фибоначчи: " + string.Join(", ", fib));


Console.WriteLine("\n=== Задание 2: Чётные числа от 2 до 20 ===");

List<int> evens = [];
for (int i = 2; i <= 20; i++)
{
    if (i % 2 == 0)
    {
       evens.Add(i);
    }
}
Console.WriteLine("Чётные числа: " + string.Join(", ", evens));


Console.WriteLine("\n=== Задание 3: Таблицу умножения от 1 до 5");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n=== Задание 4: Ввод пароля");

string password = "qwerty";

do
{
        Console.Write("Введите пароль: ");
    string input = Console.ReadLine();
    if (input != password)
    {
        Console.WriteLine("Неверный пароль. Попробуйте снова.");
    }
    else
    {
        Console.WriteLine("Пароль верный. Доступ разрешён.");
        break;
    }
}while (true);