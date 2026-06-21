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

    static int KullanicidanTahminAl()
    {
        int girilenSayi = 0;
        bool gecerliGiris = false;
        while (!gecerliGiris)
        {
            Console.Write("Lütfen tahmininizi girin: ");
            string giris = Console.ReadLine();
            if (int.TryParse(giris, out girilenSayi))
            {
                gecerliGiris = true;
            }
            else
            {
                Console.WriteLine(">> HATA: Lütfen sadece rakamları kullanarak geçerli bir sayı girin!\n");
            }
        }
        return girilenSayi;
    }
}