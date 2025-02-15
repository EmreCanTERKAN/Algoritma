Console.WriteLine("Bir sayı giriniz");
string sayi = Console.ReadLine();

if (IsPalidrome(sayi))
    Console.WriteLine($"Sayı palidrom sayısıdır {sayi}");
else
    Console.WriteLine($"Sayı palidrom sayısı değildir {sayi}");



static bool IsPalidrome(string str)
{
    str = str.Replace(" ", "").ToLower();
    string reversedStr = new string(str.Reverse().ToArray());
    return str.Equals(reversedStr);

}