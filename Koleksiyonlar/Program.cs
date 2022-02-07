// See https://aka.ms/new-console-template for more information
using Koleksiyonlar;
using System.Collections.Generic;

string[] isimler = new string[] {"Çağrı","Murat","Musab","İlker"};
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);


List<string> isimler2=new List<string>() { "Çağrı", "Murat", "Musab", "İlker" };
isimler2.Add("Özay");
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("Özay");
Console.WriteLine(isimler2[4]);

