using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraymantigi
{
    internal class Program
    {
        // convention : yazım kuralı olarak düşünebiliriz 
        // intelisense : akıllı özelliği, seçenek çıkartması ;tamamlaması tab tab vs 
        // alias =takma ad 
        // foreach (string kurs in kurslar ) =>> burda ki kursa Alias diyoruz. yani sen buraya a,b,c ,x vs desen çalışır. Takma isim vceriyoruz .
        static void Main(string[] args)
        {
            // Mantık şu diyelim manavın var meyveleri kaydediceksin urun1,urun2,urun3... vs diye birsürü değişken ekleyip onlara değer ataman gerekirdi
            string urun1 = "elma";
            string urun2 = "çilek";
            string urun3 = "portakal";
            Console.WriteLine(urun1+" "+urun2+" "+urun3); //her bir ürün için ayrı ayrı değişken atayıp  yazdırmak gerekiyordu fakat bu çok çok gereksiz
            // bunun yerine bir adet değişkende birden fazla ürün tutabilirim array yontemiyle . 
            string [] urunler=new string[] { "elma", "çilek", "portakal" };
            foreach (string urun in urunler)
            {
                Console.WriteLine(urun);    
            }
            // Peki birden fazla ürüne, ürünün Id si, ismi, fiyatı, açıklaması gibi özellikleri eklemek istesek? İşte burda classlar devreye giriyor. 
            //---------------------------------------------------------------------------------------------------
            Console.WriteLine("***********1. yöntem yanlıştır. ***************");
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2= "Programlamaya başlangıç için temel kurs ";
            string kurs3 = "Java";
            string kurs4 = "Python ";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine( "************************* Dizi İle yapıyoruz  -burda for döngüsü kullandık****************************");
            // bu şekilde tekrarlı yazmak yerine arraydan yararlanırız. örn Javascript diye bir değere yazdırmak istiyorum. bunun için tekrar bir değşken oluşturup
            // console.writeline yazmam gerekiyordu. E ticaret sitesini düşünelim elimde çok fazla ürün var. Herbiri için değişken oluşturmak çok mantıksız olurç 
            // bu gibi durumlarda liste yapısı kullanırız. İşlevleri aynıbirden fazla eleman! 
            //string kurs6  yerine string [] array kullanıyorum  ==>> string[] kurslar = new string[] {"","", }
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs ",
                "Java", 
                "Python " }; // 4 adet değişken tanımlamak yerine doğru kullanım budur .
            // Ama gerçek hayatta string [] kurslar= UrunleriGetir(); şeklinde kullanılır 
            // bu şekilde tek tek for döngüsü döndüğü sürece dizimizin elemanlarını gezecek 
            for (int i = 0; i <kurslar.Length; i++) // <= 3 yerine ==>>>   <kurslar.Length diyebilirz. length ile kursların eleman sayısı kadar demiş olduk
            {
                Console.WriteLine(kurslar[i]);  

            }

            Console.WriteLine("************FOR BİTTİ FOREACH DÖNGÜSÜYLE YAPIYORUZ. foreach dizi elemanlarını  tek tek dolaşmaya yarıyor.  **********");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("**************************");

            // 3 şekilde array tanımlayabilirim
            //------------------------------------------------------------------
            //1
            string[] urunler2 = new string[] { "karpuz", "kivi", "portakal" };
            foreach (string urun in urunler2)
            {
                Console.WriteLine(urun);
            }
            //-------------------------------------------------------------------
            //2
            string[] urunler3 = { "karpuz", "kivi", "portakal" };
            //------------------------------------------------------------------
            //3
            string[] urunler4 = new string[3];
            {
                urunler4[0] = "karpuz";
                urunler4[1] = "kivi";
                urunler4[2] = "portakal";


            }

            //-----------------------------------ÇOK BOYUTLU DİZİLER-Multidimensional Arrays----------------------------------------------
            //BOYUT: DİMENSİON
            //Multidimensional Arrays=> çok boyutlu diziler
            //Türkiye nin 7 cografi  bölgesini ve onların 3 adet şehrini baz alalım 
            //ÇOK BOYUTLU DİZİLER 0 DAN BAŞLAMAZ 1 DEN BAŞLAr
            Console.WriteLine("----------------    TÜRKİYE'NİN COĞRAFİ BÖLGELERİ     ----------------");
            string[,] sehirler=new string[7,3];
            //Türkiye de 7adet bölge vardır. Burda ki 7 satır, 3 ise sutun olarak düşünebiliriz. 

            string[,] sehirler4 = new string[7, 3]
            //0. deminson(daymenşın)=7 => satırlar
            //1.deminson=3v => surunlaR
            //get upper bound ile en büyük dimension sayısını alıyoruz 
            {
                {"Antalya","Burdur","Isparta"}, // AKDENİZ BÖLGESİ
                {"Malatya","Erzincan","Elazığ"}, //Doğu Anadolu Bölgesi
                {"İzmir","Aydın","Muğla"},//Ege Bölgesi
                {"Gaziantep","Kilis","Adıyaman"},//Güneydoğu Anadolu Bölgesi
                {"Sivas","Konya","Ankara"},//İç Anadolu Bölgesi
                {"Bolu","Düzce","Zonguldak"}, //Karadeniz Bölgesi
                {"İstanbul","Çanakkale","Balıkesir"}, //Marmara Bölgesi
            };

            for (int i =0; i <= sehirler4.GetUpperBound(0); i++) //GetUpperBound(0)=>0. DIMENSIONUN(BOYUTUN) EN ÜST DEĞERI 
            {
                switch (i)
                {
                    case 0: Console.WriteLine("***************AKDENİZ BÖLGESİ***************"); break;
                    case 1: Console.WriteLine("***************Doğu Anadolu Bölgesi***************"); break;
                    case 2: Console.WriteLine("***************Ege Bölgesi***************"); break;

                    case 3: Console.WriteLine("***************Güneydoğu Anadolu Bölgesi***************"); break;
                    case 4: Console.WriteLine("***************İç Anadolu Bölgesi***************"); break;
                    case 5: Console.WriteLine("***************Karadeniz Bölgesi***************"); break;
                    case 6: Console.WriteLine("***************Marmara Bölgesi***************"); break;

                }
                for (int j =0; j <= sehirler4.GetUpperBound(1); j++)//GetUpperBound(1)=>1. DIMENSIONUN(BOYUTUN) EN ÜST DEĞERI
                {
                    Console.WriteLine(sehirler4[i,j]);

                }





            }
            Console.ReadLine();



        }
    }
}
