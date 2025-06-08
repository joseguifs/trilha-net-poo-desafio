using DesafioPOO.Models;

Iphone iphone = new("12345", "Modelo 1", "111111", 32);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new("4988", "Modelo 2", "22222", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");