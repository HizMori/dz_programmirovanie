using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите длину массива source: ");
        int[] source = new int[int.Parse(Console.ReadLine())];
 
        // заполним массив руками
        for (int i = 0; i < source.Length; i++)
        {
            Console.Write($"Введите {i+1} значение массива: ");
            source[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив:\n" + string.Join(" ", source));
        int min = source[0], size = 1;
 
        for (int i = 1; i < source.Length; i++)
        {
            if (source[ i ] <= min) source[i] = 0;
            if (source[ i ] > min)
            {
                min = source[i];
                size++;
            }
        }
 
        int[] result = new int[size];
        int c = 0;
        for (int i = 0; i < source.Length; i++)
        if (source[ i ] > 0) result[c++] = source[i];
 
        Console.WriteLine("Новый массив:\n" + string.Join(" ", result));
 
        Console.ReadKey();
    }
}