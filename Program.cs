namespace Tanımlama__Erişim_ve_Döngülerle_Dizi_Kullanımı;

class Program
{
    static void Main(string[] args)
    {//Dizi Tanımlama//
   /* string[] renkler = new string[5];//-->New string ile değer ataması yaptık
    string[] hayvanlar = {"Kuş","Kedi","Köpek"};//--> Burada ise direkt olarak hayvanların atamasını yaptık
    int[] dizi;
    dizi = new int[5];//Diziye 5 değer ataması yaptık
    //Dizilere Değer atama kısmı//
    renkler[0] = "mavi";//Renkler dizisindeki "0"  a mavi ataması yaptık.
    dizi[3] = 10;//Dizi kısmındaki 3.değere 10 ataması yaptık
    renkler[1] ="kırmızı";
    dizi[1] = 25;

    Console.WriteLine(hayvanlar[1]);
    Console.WriteLine(dizi[3]);
    Console.WriteLine(renkler[0] + dizi[1]); //Renklerin 0'atanan değeri ile dizideki 1'atanan değeri yazdırdık*/



Console.Write("Lütfen dizinin eleman sayısını giriniz:");
int diziUzunluğu = int.Parse(Console.ReadLine()!); //Kullanıcıdan dizi eleman sayısı girmesi için readline oluşturduk
//ve dizi uzunluğu değerini kişinin gireceği değere eşitledik
int[] sayiDizisi = new int[diziUzunluğu];//Burada ise newintdiziuzunluğu ile ekrandan alınan sayı ile boyutu belirledik
//Dizinin elemanlarını konsoldan alabilmek için for kullacağınız
for (int i = 0; i < diziUzunluğu; i++)
{
    Console.Write("Lütfen {0}. sayisi giriniz:", i+1);//i+1 kullanma sebebimiz kullanıcıya 
    //0.sayıyı girmek mantıklı olmadığı için.
    sayiDizisi[i] = int.Parse(Console.ReadLine()!);

}
int toplam = 0;
foreach (var sayi in sayiDizisi)//collection tip döngülerde geri dönmemizi sağlayan döngüydü
{
    toplam += sayi;
}
 Console.WriteLine("Ortalama:" + toplam/diziUzunluğu);
    }
}
