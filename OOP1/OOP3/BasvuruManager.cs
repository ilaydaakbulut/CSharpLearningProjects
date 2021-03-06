using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //method injection
        {
            krediManager.Hesapla();
         }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var i in krediler)
            {
                i.Hesapla();
            }
        }
    }
}
