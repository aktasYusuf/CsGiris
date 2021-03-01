using System;
using System.Collections.Generic;

namespace OOP3
{                                  //İnterface'ler de o interface'i implemente eden class'ın referans numarasını tutabiliyor.
    class Program                           //örnekte olduğu gibi
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new SmsLoggerService(),new DatabaseLoggerService() });
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
