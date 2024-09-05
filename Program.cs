using DesafioPOO.Models;

Console.WriteLine("Smartphone Mokia");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("-------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "789123", modelo: "Iphone", imei: "789123", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WAZE");