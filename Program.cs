var aquila = new Aquila("grido", "mammiferi");
var passerotto = new Passerotto("cip-cip" , "piccoli insetti");
var delfino = new Delfino("canto" , "pesci" );
var cane = new Cane("abbaio" , "crocchette");
Console.WriteLine("Aquila");
aquila.PrintDormi();
aquila.PrintVerso();
aquila.Vola();
Console.WriteLine(aquila.GetMangia());

Console.WriteLine("--------------------");

Console.WriteLine("Passerotto");
passerotto.PrintDormi();
passerotto.PrintVerso();
passerotto.Vola();  
Console.WriteLine(passerotto.GetMangia());

Console.WriteLine("--------------------");

Console.WriteLine("Delfino");
delfino.PrintDormi();
delfino.PrintVerso();
delfino.Nuota();
Console.WriteLine(delfino.GetMangia());

Console.WriteLine("--------------------");

Console.WriteLine("Cane");
cane.PrintDormi();
cane.PrintVerso();
cane.Nuota();
Console.WriteLine(cane.GetMangia());

