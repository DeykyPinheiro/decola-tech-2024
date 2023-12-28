using DesafioCelular.Models;

Smartphone nokia = new Nokia("123456789", "Nokia", "123456789", 300);
nokia.InstalarAplicativo("tes");
nokia.InstalarAplicativo("galinho");
nokia.InstalarAplicativo("estilingue");
nokia.ApresentacaoSmartphone();
nokia.ExibirListaDeApps();


Smartphone iphone = new Iphone("zzzzzzzzzzz", "iphone", "aaaaaaaaaa", 200);
iphone.InstalarAplicativo("tes");
iphone.InstalarAplicativo("b");
iphone.InstalarAplicativo("c");
iphone.ApresentacaoSmartphone();
iphone.ExibirListaDeApps();