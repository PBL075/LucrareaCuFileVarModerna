using System;
using System.IO;

namespace var_modern_file
{
    class Program
    {
        static void Main()
        {
            string numeFisier = "note.txt";
            string continut = "Salut! Acest text este salvat folosind metoda moderna C#.";

            File.WriteAllText(numeFisier, continut);

            if (File.Exists(numeFisier))
            {
                string textCitit = File.ReadAllText(numeFisier);
                Console.WriteLine(textCitit);
            }
        }
    }
}