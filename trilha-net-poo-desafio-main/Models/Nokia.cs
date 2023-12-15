using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"

    public class Nokia : Smartphone
    {
 // Novas propriedades específicas da classe Nokia
    public string NomeUsuario { get; set; }
    public int AnoFabricacao { get; set; }
    public Nokia(string numero, string modelo, string imei, string memoria): base(numero, modelo, imei, memoria)
        {      }
        // Sobrescreve o método InstalarAplicativo da classe base Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Nokia...");
            // Implementação específica para a instalação de aplicativos em um Nokia
        }
    }
}
