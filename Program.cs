﻿using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "GSM 3320", imei: "0123456789", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "987", modelo: "iPhone 15 Plux", imei: "998877665544", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");