using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yerleştirme kampı";
            string kurs2 = "programlamaya başlangıc için temel kurs";
            string kurs3 = "java";

            string[] kurslar = new string[] { "yazılım geliştirici yerleştirme kampı", "programlamaya başlangıc için temel kurs","java","python" };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            
            foreach (string i in kurslar) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
