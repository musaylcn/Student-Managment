using System;
using System.Collections.Generic;

abstract class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Numara { get; set; }
    public string Bolum { get; set; }

    public Ogrenci(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;

    }
    public Ogrenci(string ad, string soyad, int numara, string bolum)
    {
        Ad = ad;
        Soyad = soyad;
        Numara = numara;
        Bolum = bolum;

    }

    public abstract void BilgiVer();
}

class Lisans : Ogrenci
{
    public int Yariyil { get; set; }

    public Lisans(string ad, string soyad, int yariyil) : base(ad, soyad)
    {
        Yariyil = yariyil;

    }

    public Lisans(string ad, string soyad, int no, int yariyil, string bolum) : base(ad, soyad, no, bolum)
    {
        Yariyil = yariyil;

    }

    public override void BilgiVer()
    {
        Console.WriteLine($"Ad {Ad},Soyad {Soyad},Numara {Numara},Bolum {Bolum},Yariyil {Yariyil}");
    }
    public void DersListesiGoster(){
        Console.WriteLine($"{Ad} icin ders listesi gösteriiliyor");
    }
}



class YuksekLisans : Ogrenci
{
    public string Danisman { get; set; }

    public YuksekLisans(string ad, string soyad,int no, string bolum, string danisman) : base(ad, soyad,no,bolum)
    {
        Danisman = danisman;

    }

    public override void BilgiVer()
    {
        Console.WriteLine($"Ad {Ad},Soyad {Soyad},Numara {Numara},Bolum {Bolum},Danisman {Danisman}");
    }
    public void DanismanRaporuAl(){
        Console.WriteLine($"{Ad} icin danisman raporu aliniyor");
    }
}




class Doktora : Ogrenci
{
    public string ArastirmaAlani { get; set; }

    public Doktora(string ad, string soyad,int no, string bolum, string arastirmaalani) : base(ad, soyad,no,bolum)
    {
        ArastirmaAlani = arastirmaalani;

    }

    public override void BilgiVer()
    {
        Console.WriteLine($"Ad {Ad},Soyad {Soyad},Numara {Numara},Bolum {Bolum},Arastirma Alani {ArastirmaAlani}");
    }
    public void DanismanRaporuAl(){
        Console.WriteLine($"{Ad} icin danisman raporu aliniyor");
    }
}



class Program
{
    static void Main(string[] args)
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        Ogrenci lisans = new Lisans("musa","yalcin",15);
        Ogrenci yukseklisans = new YuksekLisans("Ayse","Kaya",20,"Bilgisayar Müh","Caner Kaya");
        Ogrenci doktora = new Doktora("Mehmet","Celik",30,"Fizik","Kuantum Mekanigi");

        ogrenciler.Add(lisans);
        ogrenciler.Add(yukseklisans);
        ogrenciler.Add(doktora);

        foreach(var ogrenci in ogrenciler){
            ogrenci.BilgiVer();
        }

        


    }
}


