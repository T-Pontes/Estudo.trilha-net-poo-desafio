using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone sphone1= new Iphone(numero: "(91)9.9161-8971", modelo: "IP2540", imei: "123456789", memoria: 16000);
Smartphone sphone2= new Iphone(numero: "(91)9.8317-1778", modelo: "NK2540", imei: "987654321", memoria: 512);

Console.WriteLine("Iniciar uma chamada:");
sphone1.Ligar();
sphone2.ReceberLigacao();

string[] listaAppIPhone = new string[] { "Uber", "Safari", "Calculadora"};
string[] listaAppNokia = new string[] { "99", "Google Chrome", "Calculadora", "Waze"};

Console.WriteLine($"{Environment.NewLine}Instalar apps no IPhone:");
foreach (var app in listaAppIPhone)
{
    sphone1.InstalarAplicativo(app);
}

Console.WriteLine($"{Environment.NewLine}Instalar apps no Nokia:");
foreach (var app in listaAppNokia)
{
    sphone2.InstalarAplicativo(app);
}
