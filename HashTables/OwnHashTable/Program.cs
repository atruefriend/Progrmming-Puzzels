// See https://aka.ms/new-console-template for more information
using OwnHashTable;
Console.WriteLine("Hello, World!");

Map myHashTable = new Map(50);
myHashTable.set("grapes", 10000);
Console.WriteLine(myHashTable.get("grapes"));
myHashTable.set("apples", 9);
Console.WriteLine(myHashTable.get("apples"));
Console.WriteLine(myHashTable.Hash("grapes"));