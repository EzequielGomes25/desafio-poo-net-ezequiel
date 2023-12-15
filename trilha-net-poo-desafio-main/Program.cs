using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "124" , modelo: "modelo2" , imei: "123131", memoria: "54" );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone Iphone = new Nokia(numero: "124" , modelo: "modelo2" , imei: "123131", memoria: "54" );
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


