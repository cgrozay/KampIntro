﻿// See https://aka.ms/new-console-template for more information

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);

int[] sayilar1=new int[] {10,20,30};

int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;

foreach (var sayi in sayilar1)
{
    Console.WriteLine(sayi);
    

}

Console.WriteLine(sayilar1[0]);