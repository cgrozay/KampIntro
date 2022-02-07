// See https://aka.ms/new-console-template for more information

using GenericsIntro;

MyList<string> isimler=new MyList<string>();
isimler.Add("Çağrı");
Console.WriteLine(isimler.Items);
foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}


