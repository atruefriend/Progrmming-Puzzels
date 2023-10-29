// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using MyLinkedList;
Console.WriteLine("Hello, World!");

MyLinkedList.MyLinkedList myLinkedList = new MyLinkedList.MyLinkedList(10);
myLinkedList.Append(5);
myLinkedList.Append(16);
myLinkedList.Append(55);
myLinkedList.Append(77);
myLinkedList.Prepend(88);
myLinkedList.Prepend(66);
myLinkedList.Prepend(1);
myLinkedList.Insert(2,99);

Console.WriteLine($"Head: {JsonSerializer.Serialize(myLinkedList.Head).ToString()}; \n Tail: {JsonSerializer.Serialize(myLinkedList.Tail).ToString()}; \n Length: {myLinkedList.Length}");

myLinkedList.Delete(2);

Console.WriteLine($"List: {JsonSerializer.Serialize(myLinkedList.GetValues())}");

myLinkedList.Tail = myLinkedList.ReverseWithRecurssion(myLinkedList.Head);

Console.WriteLine($"List: {JsonSerializer.Serialize(myLinkedList.GetValues())}");
Console.WriteLine($"Head: {JsonSerializer.Serialize(myLinkedList.Head).ToString()}; \n Tail: {JsonSerializer.Serialize(myLinkedList.Tail).ToString()}; \n Length: {myLinkedList.Length}");


myLinkedList.Reverse();

Console.WriteLine($"List: {JsonSerializer.Serialize(myLinkedList.GetValues())}");
Console.WriteLine($"Head: {JsonSerializer.Serialize(myLinkedList.Head).ToString()}; \n Tail: {JsonSerializer.Serialize(myLinkedList.Tail).ToString()}; \n Length: {myLinkedList.Length}");


// MyLinkedList.MyDoubleLinkedList myDoubleLinkedList = new MyLinkedList.MyDoubleLinkedList(10);
// myDoubleLinkedList.Append(5);
// myDoubleLinkedList.Append(16);
// myDoubleLinkedList.Append(55);
// myDoubleLinkedList.Append(77);
// myDoubleLinkedList.Prepend(88);
// myDoubleLinkedList.Prepend(1);
// myDoubleLinkedList.Prepend(66);
// myDoubleLinkedList.Insert(5,99);

// //Console.WriteLine($"Head: {JsonSerializer.Serialize(myDoubleLinkedList.Head).ToString()}; \n Tail: {JsonSerializer.Serialize(myDoubleLinkedList.Tail).ToString()}; \n Length: {myDoubleLinkedList.Length}");

// //myDoubleLinkedList.Delete(2);

// Console.WriteLine($"List: {JsonSerializer.Serialize(myDoubleLinkedList.GetValues())}");