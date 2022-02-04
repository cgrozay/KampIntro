// See https://aka.ms/new-console-template for more information
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C# yetiştirme kampı";
kurs1.Egitmen = "Çağrı Özay";
kurs1.IzlenmeOrani = 86;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java yetiştirme kampı";
kurs2.Egitmen = "Ayşe Özay";
kurs2.IzlenmeOrani = 98;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python yetiştirme kampı";
kurs3.Egitmen = "Ali Özay";
kurs3.IzlenmeOrani = 86;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++ yetiştirme kampı";
kurs4.Egitmen = "Elif Özay";
kurs4.IzlenmeOrani = 100;

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi+ ": "+kurs.Egitmen+": "+kurs.IzlenmeOrani);
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}
