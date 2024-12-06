using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia Tijolão", imei: "456431461", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Tik Tok");


Console.WriteLine("\n");


Console.WriteLine("Iphone:");

Smartphone iphone = new Iphone(numero: "4987", modelo: "Iphone 15 pro MAX", imei: "481684248", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");