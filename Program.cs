using System;

class Program
{
    // Глобальная переменная для Задания 7
    static int counter = 0;

    static void Main()
    {
        Console.WriteLine("=== Задание 1 ===");
        SayHello();
        SayHello();
        SayHello();

        Console.WriteLine("\n=== Задание 2 ===");
        Greet("Саша");
        Greet("Ярослав");
        Greet("Анна");

        Console.WriteLine("\n=== Задание 3 ===");
        PrintPerson("Егор", 15, "Москва");
        PrintPerson("Мария", 22, "Санкт-Петербург");

        Console.WriteLine("\n=== Задание 4 ===");
        PrintPersonDefault("Алексей", 25, "Программирование");
        PrintPersonDefault("Дмитрий");

        Console.WriteLine("\n=== Задание 5 ===");
        int result = Square(5);
        Console.WriteLine($"Квадрат числа: {result}");

        Console.WriteLine("\n=== Задание 6 ===");
        RunCalculator();

        Console.WriteLine("\n=== Задание 7 ===");
        Increment();
        Console.WriteLine($"Counter: {counter}");
        Increment();
        Console.WriteLine($"Counter: {counter}");
        Increment();
        Console.WriteLine($"Counter: {counter}");

        Console.WriteLine("\n=== Задание 8 ===");
        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(2, 3, 4));
        Console.WriteLine(Multiply(2.5, 4.0));
    }

    // --- Методы Задания 1 ---
    static void SayHello()
    {
        Console.WriteLine("Привет, мир!");
    }

    // --- Методы Задания 2 ---
    static void Greet(string name)
    {
        Console.WriteLine($"Привет, {name}!");
    }

    // --- Методы Задания 3 ---
    static void PrintPerson(string name, int age, string city)
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}  Город: {city}");
    }

    // --- Методы Задания 4 ---
    static void PrintPersonDefault(string name, int age = 18, string hobby = "Не указано")
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Хобби: {hobby}");
    }

    // --- Методы Задания 5 ---
    static int Square(int x)
    {
        return x * x;
    }

    // --- Методы Задания 6 ---
    static void RunCalculator()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Результат: {Add(num1, num2)}");
                break;
            case "-":
                Console.WriteLine($"Результат: {Subtract(num1, num2)}");
                break;
            case "*":
                Console.WriteLine($"Результат: {Multiply(num1, num2)}");
                break;
            case "/":
                if (num2 == 0)
                    Console.WriteLine("Ошибка: деление на ноль!");
                else
                    Console.WriteLine($"Результат: {Divide(num1, num2)}");
                break;
            default:
                Console.WriteLine("Неизвестная операция.");
                break;
        }
    }

    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static double Divide(int a, int b) => (double)a / b;

    // --- Методы Задания 7 ---
    static void Increment()
    {
        counter++;
    }

    // --- Методы Задания 8 (перегрузки Multiply) ---
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
