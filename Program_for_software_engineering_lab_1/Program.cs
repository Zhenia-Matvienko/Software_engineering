using System;
class Program_for_software_engineering_lab_1
{
    static void Fibonacci_numbers(int n)
    {
        Console.Write("Числа Фібоначчі до " + n + " члена: ");
        double fibonacci_number = 0;
        double golden_ratio = (1 + Math.Sqrt(5)) / 2;
        for (int i = 0; i < n; i++)
        {
            fibonacci_number = Math.Round((Math.Pow(golden_ratio, i) - Math.Pow(-golden_ratio, -i)) / (2 * golden_ratio - 1));
            Console.Write(fibonacci_number + " ");
        }
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        label:
        Console.Write("Введіть натуральне число, яке буде визначати скільки чисел Фібоначчі необхідно вивести: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            Fibonacci_numbers(n);
        }
        else
        {
            Console.WriteLine("Ваше число не є натуральним, тому спробуйте ввести інше число.");
            goto label;
        }
    }
}