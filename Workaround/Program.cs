
using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        SelamVer("Halil");
        SelamVer();
        int sonuc = Topla(50);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Halil";
        ogrenciler[1] = "Enes";
        ogrenciler[2] = "Hakan";
        ogrenciler = new string[4];
        ogrenciler[3] = "Seda";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler = new[] {"Ankara", "İstanbul", "İzmir"};
        string[] sehirler2 = new[] { "Bursa", "Balıkesir", "Düzce" };

        sehirler2 = sehirler;
        sehirler[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        Person person1 = new Person();
        person1.FirstName = "Halil";


        Person person2 = new Person();
        person2.FirstName = "Enes";
        person2.LastName = "Dursan";
        person2.DateOfBirtYear = 2014;
        person2.NationalIdentity = 11163517245;

        

        foreach (string sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> { "Adıyaman" , "Diyarbakır" , "Gaziantep"};
        yeniSehirler1.Add("Antalya");

        foreach (var item in yeniSehirler1)
        {
            Console.WriteLine(item);
        }


        PttManager pttManager = new PttManager(new ForeignerManager());

        PersonManager personManager1 = new PersonManager();
        Console.WriteLine(personManager1.CheckPerson(person2));



        Console.ReadLine();
    }

    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 15)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam = " + sonuc);
        return sonuc;
    }
}