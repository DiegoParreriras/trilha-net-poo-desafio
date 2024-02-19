using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "5293963801", modelo: "11111", imei: "112233", memoria: 32);
Smartphone iphone = new Iphone(numero: "8881234678", modelo: "222333", imei: "1309128", memoria: 128);

Console.WriteLine("Smartphone Nokia;");
nokia.Ligar(iphone.Numero);
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("_________________________");

Console.WriteLine("Smartphone Iphone;");

iphone.ReceberLigacao(nokia.Numero);
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("_________________________");