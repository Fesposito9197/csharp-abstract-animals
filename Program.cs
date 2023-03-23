var aquila = new Aquila("grido", "mammiferi");
var passerotto = new Passerotto("cip-cip" , "piccoli insetti");
var delfino = new Delfino("canto" , "pesci" );
var cane = new Cane("abbaio" , "crocchette");
Console.WriteLine("Aquila");
aquila.PrintDormi();
aquila.PrintVerso();
Console.WriteLine(aquila.GetMangia());

Console.WriteLine("Passerotto");
passerotto.PrintDormi();
passerotto.PrintVerso();
Console.WriteLine(passerotto.GetMangia());

Console.WriteLine("Delfino");
delfino.PrintDormi();
delfino.PrintVerso();
Console.WriteLine(delfino.GetMangia());

Console.WriteLine("Cane");
cane.PrintDormi();
cane.PrintVerso();
Console.WriteLine(cane.GetMangia());

