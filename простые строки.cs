using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите слово, длинной 4 и более буквы: ");
        string x = Console.ReadLine();
        int len = x.Length;
        if (len >= 4)
        {
          if (x[1] == x[3])
          {
            Console.WriteLine("Символы одинаковые");
          }
          if (x[1] != x[3])
          {
            Console.WriteLine("Символы неодинаковые");
          }
        }
        else
        {
          Console.WriteLine("Слово меньше 4 букв");
        }
        Console.ReadLine();
    }
}