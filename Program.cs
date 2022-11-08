using DesafioPOO.Models;

Smartphone nokia = new Nokia("1234-5678", "1100","47845es8" , 16);
Smartphone iphone = new Iphone("7890-1234","Iphone 11 pro max","E7IHn8",32);


nokia.Ligar();
nokia.InstalarAplicativo("Tetris");
nokia.ExibirNumero();
nokia.Numero= "7894-5612";
nokia.ExibirNumero();

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();