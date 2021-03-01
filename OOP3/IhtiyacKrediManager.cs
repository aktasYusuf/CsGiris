using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void CıktıAlma()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
