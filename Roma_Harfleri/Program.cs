
Console.WriteLine(RomanCevirici.RomandanSayiya("LVILIIV"));
Console.WriteLine(RomanCevirici.SayidanRomana(1994));


public static class RomanCevirici
{
    // Roma rakamlarını sayıya çevir
    public static int RomandanSayiya(string roman)
    {
        var romanDegerler = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int toplam = 0;
        int gercekDeger = 0;

        // Sağdan sola doğru işle
        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int guncelDeger = romanDegerler[roman[i]];

            if (guncelDeger < gercekDeger)
                toplam -= guncelDeger; // Önceki değer daha büyükse çıkar (IV, IX gibi)
            else
                toplam += guncelDeger;

            gercekDeger = guncelDeger;
        }

        return toplam;
    }

    // Sayıyı Roma rakamına çevir
    public static string SayidanRomana(int sayi)
    {
        if (sayi < 1 || sayi > 3999)
            throw new ArgumentException("1-3999 arası sayı girin.");

        var romanSembol = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400, "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };

        string sonuc = "";
        foreach (var cift in romanSembol)
        {
            while (sayi >= cift.Item1)
            {
                sonuc += cift.Item2;
                sayi -= cift.Item1;
            }
        }

        return sonuc;
    }
}