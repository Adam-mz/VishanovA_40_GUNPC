

Console.WriteLine("=== Задание 1: Первые 8 чисел Фибоначчи ===");

int[] fib = new int[8];
   fib[0] = 0;
   fib[1] = 1;
for (int i = 2; i<fib.Length;i++)
    fib[i] = fib[i-1] + fib[i-2];
Console.WriteLine("Fibonacci: " + string.Join(", ", fib));


Console.WriteLine("\n=== Задание 2: Массив месяцев ===");

string[] months = new string[]
{
    "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
};
Console.WriteLine("Месяцы года: " + string.Join(", ", months));


Console.WriteLine("\n=== Задание 3: Матрица 3x3 ===");

int[,] matrix = new int[3, 3]
       {
            { (int)Math.Pow(2, 1), (int)Math.Pow(3, 1), (int)Math.Pow(4, 1) },
            { (int)Math.Pow(2, 2), (int)Math.Pow(3, 2), (int)Math.Pow(4, 2) },
            { (int)Math.Pow(2, 3), (int)Math.Pow(3, 3), (int)Math.Pow(4, 3) }
       };
for (int i = 0; i  < 3; i ++)

{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine("\n");
}

Console.WriteLine("\n=== Задание 4: Jagged Array ===");

double[][] jagged = new double[3][];


jagged[0] = new double[] { 1, 2, 3, 4, 5 };


jagged[1] = new double[] { Math.E, Math.PI };


jagged[2] = new double[]
{
            Math.Log10(1),
            Math.Log10(10),
            Math.Log10(100),
            Math.Log10(1000)
};

Console.WriteLine("Jagged array:");

for (int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine("Row " + (i + 1) + ": " + string.Join(", ", jagged[i]));
}

Console.WriteLine("\n=== Задание 5: Копирование элементов массива ===");

int[] array = { 1, 2, 3, 4, 5 };
int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };


Array.Copy(array, array2, 3);

Console.WriteLine("array2 после копирования:");
Console.WriteLine(string.Join(", ", array2));


Console.WriteLine("\n=== Задание 6: Увеличение размера массива ===");


Array.Resize(ref array, array.Length * 2);

Console.WriteLine("array после Resize:");
Console.WriteLine(string.Join(", ", array));