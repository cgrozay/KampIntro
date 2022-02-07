// See https://aka.ms/new-console-template for more information

using OOP3;
using System.Collections.Generic;

IKrediManager tasitKredi = new TasitKrediManager();
IKrediManager ihtiyacKredi = new IhtiyacKerdiManager();
IKrediManager konutKredi = new KonutKrediManager();
ILoggerService databaseLoggerService=new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();



BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKredi, fileLoggerService);

List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKredi,konutKredi,tasitKredi };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
