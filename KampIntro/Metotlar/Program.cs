using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elmasi";

            Urun urun2 = new Urun();

            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var i in urunler)
            {
                Console.WriteLine(i.Adi);
                Console.WriteLine(i.Fiyati);
                Console.WriteLine(i.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("---------------metotlar------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","yesil armut",12);
            sepetManager.Ekle2("elma","yesil elma",12);
            sepetManager.Ekle2("karpuz", "diyarbakir karpuzu", 12);
        }
    }
}
