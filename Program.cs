using system;

public class Program
{
    static int kullaniciTahmini;
    static int bilgisayarTahmini;

    public static void Main()
    {
        kullaniciTahmini = 5;
        bilgisayarTahmini = 10;
    }








}


public static void Secenekler(){


            Console.WriteLine("=================================================");
            Console.WriteLine("          SAYI TAHMİN OYUNUNA HOŞ GELDİNİZ       ");
            Console.WriteLine("=================================================");
            Console.WriteLine("Kurallar:");
            Console.WriteLine("- Bilgisayar 1 ile 100 arasında bir sayı tutar.");
            Console.WriteLine("- Yaptığınız tahmine göre bilgisayar sizi yönlendirir.");
            Console.WriteLine("- En az denemede sayıyı bulmaya çalışın!");
            Console.WriteLine("-------------------------------------------------\n");



}
static int RastgeleSayiUret(int min, int max)
{
    Random rastgele = new Random();
    // max değere 1 ekliyoruz çünkü Next metodunda üst sınır dahil değildir.
    return rastgele.Next(min, max + 1);
}
static bool TahminiKontrolEt(int tahmin, int hedef)
{
    if (tahmin < hedef)
    {
        Console.WriteLine(">> İPUCU: Daha BÜYÜK bir sayı girmelisin.\n");
        return false;
    }
    else if (tahmin > hedef)
    {
        Console.WriteLine(">> İPUCU: Daha KÜÇÜK bir sayı girmelisin.\n");
        return false;
    }
    else
    {
        return true; // Tahmin hedefe eşitse oyun biter
    }
}

