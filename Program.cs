using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("79999667788", "A440", "000000-00-000000-0", 2048);
Iphone iphone = new("79999667788", "XII", "111111-11-111111-1", 4096);

nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.Clear();

iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");