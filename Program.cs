﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "123456",modelo: "tijolo", imei: "111111", memoria: 2000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Smartphone iphone = new Iphone(numero: "7891011",modelo: "nave", imei: "22222", memoria: 4000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");