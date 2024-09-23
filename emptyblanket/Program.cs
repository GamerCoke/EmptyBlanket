
// See https://aka.ms/new-console-template for more information
using EmptyBlanket;

Console.WriteLine("Hello, World!");

Console.WriteLine("What the fork!");

Console.WriteLine("O");

Dog dog1 = new Dog(4, 6, 2);

Console.WriteLine($"{dog1.CommitBark()}");
Console.WriteLine($"{dog1.CommitDrool()}");
Console.WriteLine($"{dog1.CommitScream()}");

Katte kat1 = new Katte("Kitto Nitto Pepito Monfito, the Cheese Connesuer", 1989, "stribet", "sort & hvid");

Console.WriteLine($"{kat1.GetInfo()}");