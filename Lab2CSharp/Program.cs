
namespace Lab2CSharp;


internal class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
        Console.WriteLine();
    }
    static int[] Create()
    {
        Console.WriteLine("Розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }
    static void task1()
    {
        int[] array;
        array= Create();
        Print(array);
        Console.WriteLine("Додатні елементи з непарними індексами:");

        for (int i = 1; i < array.Length; i += 2) // Індекс непарний
        {
            if (array[i] > 0)
            {
                Console.WriteLine($"Елемент[{i}]: {array[i]}");
            }
        }
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введіть значення для елемента [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Матриця:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Додатні елементи з непарними індексами:");

        for (int i = 1; i < rows; i += 2) // Перший індекс непарний
        {
            for (int j = 0; j < columns; j ++) 
            {
                if (matrix[i, j] > 0)
                {
                    Console.WriteLine($"Елемент[{i}, {j}]: {matrix[i, j]}");
                }
            }
        }
    }
    static void task2()
    {
        int[] array;
        array = Create();
        Print(array);
        int count = 0;

        // Підрахунок кількості пар
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість пар, в яких попередній елемент менше наступного: {count}");
    }
    static void task3()
    {
        Console.Write("Введіть розмірність масиву (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Елемент[{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nПочаткова матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Обмін місцями стовпців за правилом
        for (int j = 0; j < n / 2; j++)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n - 1 - j];
                matrix[i, n - 1 - j] = temp;
            }
        }

        Console.WriteLine("\nМатриця після обміну стовпців:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void task4()
    {
        // Введення значень для створення східчастого масиву
        Console.Write("Введіть кількість рядків у східчастому масиві: ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];

        // Заповнення східчастого масиву вручну з консолі
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у {i + 1}-му рядку: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            Console.WriteLine($"Введіть елементи для {i + 1}-го рядку:");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент[{j}]: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Східчастий масив:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        // Введення числа, більше якого потрібно підрахувати елементи
        Console.Write("Введіть число, більше якого потрібно підрахувати елементи: ");
        int threshold = int.Parse(Console.ReadLine());

        // Підрахунок та виведення результатів
        Console.WriteLine("\nКількість елементів, більших за задане число, для кожного рядка:");
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            foreach (int element in jaggedArray[i])
            {
                if (element > threshold)
                {
                    count++;
                }
            }
            Console.WriteLine($"Рядок {i + 1}: {count} елементів");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Lab 2 CSharp");
        while (true)
        {
            Console.WriteLine("Введiть номер завдання:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                default:
                    Console.WriteLine("Не вiрно");
                    break;
            }
        }
    }
}
