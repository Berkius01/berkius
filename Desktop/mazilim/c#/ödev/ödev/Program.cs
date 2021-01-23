using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            musteri musteri1 = new musteri();
            musteri1.id = 21895855;
            musteri1.name = "berk";
            musteri1.sName = "saglicak";

            musteri musteri2 = new musteri();
            musteri1.id = 21895558;
            musteri1.name = "kubilay";
            musteri1.sName = "arslan";


            musteriManager manager = new musteriManager();

            manager.ekle(musteri1);
            manager.ekle(musteri2);
            manager.sil(musteri2);
        }
    }
}
