using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Введите день: ");
        int day = int.Parse(Console.ReadLine());
        DateTime data = new DateTime(year, month, day);
        int week = (int)data.DayOfWeek;
        Console.WriteLine($"День недели {data}: {week}");
        Console.ReadLine();
    }
}