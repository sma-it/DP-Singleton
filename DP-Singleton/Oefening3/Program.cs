// Begin met het uitwerken van de logger en de account class
// Daarna voeg je hieronder code toe om alle log messages te tonen op het scherm

using Oefening3;

Account accountJarno = new Account("Freddy");
Account accountEls = new Account("Els");

accountJarno.AddAmount(100);
accountEls.AddAmount(150);

accountJarno.Withdraw(45);
accountEls.Withdraw(23);

// TODO: toon alle log messages

foreach(var line in Logger.Instance().GetLogMessages())
{
    Console.WriteLine(line);
}