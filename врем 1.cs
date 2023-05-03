using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Введите день: ");
        int day = int.Parse(Console.ReadLine());
        DateTime rod = new DateTime(year, month, day);
        DateTime today = DateTime.Today;
        DateTime next = rod.AddYears(today.Year - rod.Year);
        int numDays = (next - today).Days;
        if (numDays < 0)
        {
            numDays = -1 * numDays;
        }
        Console.WriteLine(numDays);
        Console.Read();
    }
}