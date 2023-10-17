using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone

            var nokia = new Nokia("123456789");
            var iphone = new Iphone("987654321");

            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.InstalarAplicativo("Facebook");
        }
    }
}
