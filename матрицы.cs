using System;

class Program {
    static void Main(string[] args) {
        int length = 12; 
        int height = 20; 
        Console.Write($"Количество столбцов матрицы: {height}"); 
        Console.Write($"Количество строк матрицы: {length}"); 
        Console.WriteLine("\nЗаполнение матрицы\n"); 
        int sum = 0;
        int[,] ara = new int[length, height]; 
        for (int i = 0; i < length; i++) 
        { 
            for (int j = 0; j < height; j++) 
            { 
                Console.Write($"Введите элемент матрицы[{i + 1}:{j + 1}]: "); 
                ara[i, j] = int.Parse(Console.ReadLine()); 
            } 
        }
        Console.WriteLine(); 
        for (int i = 0; i < length; i++) 
        { 
            for (int j = 0; j < height; j++) 
            { 
                Console.Write(String.Format("{0,7}", ara[i, j])); 
                sum += ara[i, j]; 
            }
            Console.WriteLine(); 
        } 
        for (int i = 0; i < height; i++)
        {
            int sumi = 0;
            for (int j = 0; j < length; j++)
            {
                sumi += ara[j, i];
            }
            Console.WriteLine($"Зарплата работника {i+1}: {sumi}");
        }
        Console.ReadKey(); 
    }
}