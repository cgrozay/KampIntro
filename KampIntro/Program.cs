// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
double toplam = ogrenciSayisi * faizOrani;
bool sistemeGirisYapmisMi = true;

double dolarDun = 7.45;
double dolarBugun = 7.45;

if (dolarDun < dolarBugun)
{
    Console.WriteLine("Yukarı Ok");
}
else if (dolarDun > dolarBugun)
{
    Console.WriteLine("Aşağı ok");
}
else
{
    Console.WriteLine("Eşittir Ok");
}

if (sistemeGirisYapmisMi == false)
{
    Console.WriteLine(toplam);
}
else
{
    Console.WriteLine(kategoriEtiketi);
}


