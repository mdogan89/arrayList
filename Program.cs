using System.Collections;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ArrayList list = new ArrayList();

list.Add("string");
list.Add(2);
list.Add(true);
list.Add('A');

Console.WriteLine(list[1]);

foreach(var item in list) {  Console.WriteLine(item); }

string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
List<int> sayilar = new List<int>() { 1, 8, 3, 7, 92, 5 };

list.AddRange(renkler);
list.AddRange(sayilar);

foreach (var item in list) { Console.WriteLine(item); }

//list.Sort();
Console.WriteLine(list);

ArrayList list1 = new ArrayList();

list1.AddRange(sayilar);

Console.WriteLine(list1.BinarySearch(9));

list1.Reverse();

foreach (var item in list1) { Console.WriteLine(item); }

list1.Clear();
foreach (var item in list1) { Console.WriteLine(item); }

//Console.ReadLine();
