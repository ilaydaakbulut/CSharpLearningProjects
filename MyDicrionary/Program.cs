using System;

namespace MyDicrionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "AA");
            myDictionary.Add(2, "BB");
            myDictionary.Add(3, "CC");
            myDictionary.Add(4, "DD");
            myDictionary.Add(5, "EE");
            myDictionary.Add(6, "FF");

            myDictionary.Show();
        }
    }
}
