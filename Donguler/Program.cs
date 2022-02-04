// See https://aka.ms/new-console-template for more information

string[] kurslar =new string[] { "Yazılım Geliştirici", "Web yazılım geliştirici", "Merhaba Dünya", "C#" };

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}