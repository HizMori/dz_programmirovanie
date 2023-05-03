using System;

class Program {
    static void Main(string[] args) {
        string[] k = { "red", "green", "black", "white", "blue" };
            StreamWriter s = new StreamWriter("doc.txt");
            foreach(string color in k)
            {
                s.WriteLine(color);
            }
            s.Close();
    }
}