using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1212121", modelo: "Nokia One", IMEI: "1221212212121212", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--- * --- * --- \n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero:"897675656", modelo: "Iphone 5S", IMEI:"6767674545467",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");