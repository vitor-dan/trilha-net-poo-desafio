using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia celularNokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Iphone celularIphone = new Iphone("987654321", "Iphone 12", "987654321", 128);

celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("WhatsApp");

celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Instagram");
