using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        double f = 0;
        if (Math.Sin(y + 5) != 0 & (Math.Log(x + 1) - Math.Pow(y, 3)) != 0)
        {
            f = (Math.Sqrt(Math.Pow(2 + y, 2) + Math.Sqrt(Math.Sin(y + 5)))) / (Math.Log(x + 1) - Math.Pow(y, 3));
        }
        Console.WriteLine("Ответ: {0}", f);
    }
}