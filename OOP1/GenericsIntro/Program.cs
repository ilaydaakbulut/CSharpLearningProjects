using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("murat");
            Console.WriteLine(isimler.Length);

            foreach (var i in isimler.Items)
            {
                Console.WriteLine(i);
            }

        }
    }
}
