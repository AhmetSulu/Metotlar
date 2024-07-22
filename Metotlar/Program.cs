// Geriye Değer Döndürmeyen Bir void metot
static void SarkıSozu()
{
    Console.WriteLine("Gerçek hayat, seni rehin alacak kendinden uzaklaştıracak.");
}
SarkıSozu();

// Geriye Tamsayı Döndüren Bir metot

static int RandomNumber()
{
    Random rastgele = new Random();
    int sayi = rastgele.Next();
    return sayi % 2;
}
int kalan = RandomNumber();
Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);

// Parametre Alan ve Geriye Değer Döndüren Bir Metot

static int Product(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}
int sonuc = Product(8, 9);
Console.WriteLine("Sayıların çarpımı: " + sonuc);


// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

static void WelcomeDear(string isim, string soyisim)
{
    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
}
WelcomeDear("Ahmet", "Sulu");