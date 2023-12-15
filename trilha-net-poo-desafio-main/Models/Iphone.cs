using System;
namespace DesafioPOO.Models
{
     // Herda da classe "Smartphone"

    public class Iphone : Smartphone
    {
 // Novas propriedades específicas da classe Apple
    public string Conta { get; set; }
    public int AnoFabricacao { get; set; }
    public Iphone(string numero, string modelo, string imei, string memoria): base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Digite o número do Nokia:");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o modelo do Nokia:");
            Modelo = Console.ReadLine();

            Console.WriteLine("Digite o IMEI do Nokia:");
            Imei = Console.ReadLine();

            Console.WriteLine("Digite a capacidade de memória do Nokia:");
            Memoria = Console.ReadLine();

        }

        // Sobrescreve o método InstalarAplicativo da classe base Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Nokia...");
            // Implementação específica para a instalação de aplicativos em um Nokia
        }
    }
}
