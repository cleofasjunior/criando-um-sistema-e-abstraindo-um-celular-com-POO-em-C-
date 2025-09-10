using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testes com Smartphone Nokia:");
        Console.WriteLine("-----------------------------");
        
        // Instancia a classe Nokia
        Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia G20", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp"); // O polimorfismo entra em ação aqui

        Console.WriteLine("\nTestes com Smartphone iPhone:");
        Console.WriteLine("------------------------------");

        // Instancia a classe Iphone
        Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "222222222", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram"); // O polimorfismo também age aqui
    }
}