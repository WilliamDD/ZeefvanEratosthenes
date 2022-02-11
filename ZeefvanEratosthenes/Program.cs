// See https://aka.ms/new-console-template for more information

//Methode
//Maak een gesorteerde lijst van alle getallen van 2 tot een zelf te kiezen maximum.
var maximum = 10000;
var priemgetallen = new ZeefvanEratosthenes.Priemgetallen();
List<int> output = priemgetallen.Zoek(maximum);

Console.WriteLine(String.Join(", ", output));
Console.WriteLine(output.Count);