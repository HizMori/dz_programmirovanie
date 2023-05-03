using System;

class Program {
    static void Main(string[] args) {
        int [] mas = {5, 0, -4, 7, 0, -3, -7, 1, 0, -2};
        Console.WriteLine($"Изначальный массив mas = [{mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}, {mas[4]}, {mas[5]}, {mas[6]}, {mas[7]}, {mas[8]}, {mas[9]}]");
        int b = 2;
        int a = 3;
        int c = 8;
        int len = mas.Length;
        for (int i = 0; i < len; i++)
        {
            if (mas[i] < 0)
            {
                mas[i] = mas[i] + mas[0];
            }
            if (mas[i] == 0)
            {
                mas[i] = mas[i] - b;
            }
        }
        Console.WriteLine($"а) mas = [{mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}, {mas[4]}, {mas[5]}, {mas[6]}, {mas[7]}, {mas[8]}, {mas[9]}]");
        for (int i = 0; i < len; i++)
        {
            if (mas[i] < 0)
            {
                mas[i] = mas[i] - b;
            }
            if (mas[i] == 0)
            {
                mas[i] = mas[i] + c;
            }
            if (mas[i] > 0)
            {
                mas[i] = mas[i] - a;
            }
        }
        Console.WriteLine($"б) mas = [{mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}, {mas[4]}, {mas[5]}, {mas[6]}, {mas[7]}, {mas[8]}, {mas[9]}]");
        Console.ReadLine();
    }
}