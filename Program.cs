using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia ("11967813116", "Nokia Indestrutivel 1", "7778963288231", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("/n");

Console.WriteLine($"Celular Iphone");
Smartphone iphone = new Iphone ("11938537556", "Iphone Sem bateria", "3658963288928", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iTunes");