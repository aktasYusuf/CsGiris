using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //public void BasvuruYap()
        //{
        //    //başvuran bilgilerini  değerlendirme 
        //    //"""""
        //    KonutKrediManager konutKrediManager = new KonutKrediManager();
        //    konutKrediManager.Hesapla();    //Bu şekilde yazım yapılırsa tüm başvuruları konut kredisine bağımlı hale getirmiş olunur.
        //}




        //aşağıdaki yapıda "method injection" yapıyoruz yanı hangi kredi türü olucağını ve hangi loglayıcı olucağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();                                         //bu yazım şekli bütün kredileri listelememizi sağlar.
            }
        }
    }
}
