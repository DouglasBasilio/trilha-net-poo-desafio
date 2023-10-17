using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            // TODO: Implementar o construtor da classe Iphone
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store do iPhone.");
        }
    }
}
