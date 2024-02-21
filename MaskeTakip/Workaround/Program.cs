// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using Workaround.Vatandas;

Console.WriteLine("Hello, World!");

string message = "Selam";

Console.WriteLine(message);

Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "Yener";
vatandas1.Soyad = "Tas";
vatandas1.DogumYili = 1900;
vatandas1.TcNo = 5568499;

Console.WriteLine(vatandas1.TcNo);


//Diziler / Arrays
string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[2] = "Kerem";
ogrenciler[1] = "Berkay";
 
for(int i=0; i<ogrenciler.Length; i++) 
{
    Console.WriteLine(ogrenciler[i]);
}

Person person2 = new Person();
person2.FirstName = "Murat";
person2.LastName = "Can";
person2.DateOfBirthYear = 1989;
person2.NationalIdentity = 123;

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


foreach (var sehir in sehirler1) //sırayla sehirler1'i gez diyor
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirleri1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirleri1.Add("İzmir 1");

foreach (var sehir in yeniSehirleri1)
{
    Console.WriteLine(sehir);

    PttManager pttManager = new PttManager(new PersonManager());
    pttManager.GiveMask(person2);



}