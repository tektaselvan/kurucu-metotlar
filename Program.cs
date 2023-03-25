using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz dizimi
            //class sinifadi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] Özellik Adı;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] Metot Adı([Parametre Listesi]);
            //     {
            //         Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // Public
            // Private
            // İnternal
            // Protected
            Console.WriteLine("Çalışan 1 Bilgileri");
            Calisan calisan1 = new Calisan("Elvan", "Tektaş", 23145687, "Bilgisayar programcısı");
            calisan1.CalisanBilgileri();


            Console.WriteLine("Çalışan 2 Bilgileri");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Zeynep";
            calisan2.Soyad = "Tektaş";
            calisan2.No = 2132343657;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();

            Console.WriteLine("Çalışan 3 Bilgileri");
            Calisan calisan3 = new Calisan("Ali", "Tektaş");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;

        }
        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
