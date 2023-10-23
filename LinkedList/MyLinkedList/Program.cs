// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using MyLinkedList;
Console.WriteLine("Hello, World!");

MyLinkedList.MyLinkedList myLinkedList = new MyLinkedList.MyLinkedList(10);
myLinkedList.Append(5);
myLinkedList.Append(16);
myLinkedList.Prepend(1);
myLinkedList.Insert(2,99);

Console.WriteLine($"Head: {JsonSerializer.Serialize(myLinkedList.Head).ToString()}; \n Tail: {JsonSerializer.Serialize(myLinkedList.Tail).ToString()}; \n Length: {myLinkedList.Length}");

myLinkedList.Delete(2);

Console.WriteLine($"List: {JsonSerializer.Serialize(myLinkedList.GetValues())}");