Console.WriteLine("Kelimeri virgülle ayırarak girin (Örnek: çiçek,çilek,çit):");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Giriş yapılmadı.");
    return;
}

string[] words = input.Split(',')
                      .Select(word => word.Trim())
                      .Where(word => !string.IsNullOrEmpty(word))
                      .ToArray();

if (words.Length == 0)
{
    Console.WriteLine("Geçerli kelime bulunamadı.");
    return;
}

string commonPrefix = LongestCommonPrefix(words);
Console.WriteLine("En uzun ortak önek: " + (commonPrefix == "" ? "(Yok)" : commonPrefix));

static string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return "";

    string reference = strs[0];
    for (int i = 0; i < reference.Length; i++)
    {
        char currentChar = reference[i];
        foreach (string str in strs)
        {
            if (i >= str.Length || str[i] != currentChar)
            {
                return reference.Substring(0, i);
            }
        }
    }
    return reference;
}
