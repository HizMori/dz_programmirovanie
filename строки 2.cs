using System;

class Program {
    static void Main(string[] args) {
        string[] ad = {"gmail.com", "mail.ru", "yandex.com"};
        Random r = new Random();
        
        string[] al = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
            "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F",
            "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "."};
            
            for (int i = 0; i < 10; i++)
            {
                string rand = ad[r.Next(0, ad.Length - 0)];
                string r1 = al[r.Next(0, al.Length)];
                string r2 = al[r.Next(0, al.Length)];
                string r3 = al[r.Next(0, al.Length)];
                string r4 = al[r.Next(0, al.Length)];
                string r5 = al[r.Next(0, al.Length)];
                string r6 = al[r.Next(0, al.Length)];
                string r7 = al[r.Next(0, al.Length)];
                string r8 = al[r.Next(0, al.Length)];
                string r9 = al[r.Next(0, al.Length)];
                Console.WriteLine( r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + "@" + rand);
            }
            Console.ReadLine();
    }
}