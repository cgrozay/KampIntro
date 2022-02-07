// See https://aka.ms/new-console-template for more information

using OOP2;

Individual individual1=new Individual();
individual1.CustomerNumber = "12345";
individual1.CustomerName = "Çağrı";
individual1.CustomerSurname = "Özay";
individual1.IdentificationNumber = "4444444444";



Corporate corporate1=new Corporate();
corporate1.CustomerId = 2;
corporate1.CustomerNumber = "23454332";
corporate1.CompanyName = "Kodlama Zmaanı";
corporate1.TaskNumber = "23312222";


Customer customer3=new Individual();
Customer customer4 = new Corporate();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(corporate1);
customerManager.Add(customer3);
customerManager.Add(customer4);
customerManager.Add(individual1);
