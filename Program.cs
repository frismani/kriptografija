using System;
     
class coder
{
 
static String raktas(String str, String key)
{
    int x = str.Length;
 
    for (int i = 0; ; i++)
    {
        if (x == i)
            i = 0;
        if (key.Length == str.Length)
            break;
        key+=(key[i]);
    }
    return key;
}
 
static String cipherText(String str, String key)
{
    String cipher_text="";
 
    for (int i = 0; i < str.Length; i++)
    {
        int x = (str[i] + key[i]) % 26;
 
        x += 'A';
 
        cipher_text+=(char)(x);
    }
    return cipher_text;
}
 
static String tekst(String cipher_text, String key)
{
    String tekstas="";
 
    for (int i = 0 ; i < cipher_text.Length &&
                            i < key.Length; i++)
    {
        int x = (cipher_text[i] -
                    key[i] + 26) %26;
 
        x += 'A';
        tekstas+=(char)(x);
    }
    return tekstas;
}
 
public static void Main(String[] args)
{
    string tekstas;
    string raktazodis; 
    
    Console.Write("Iveskite teksta, kuri koduosime: ");
    tekstas = Console.ReadLine().ToUpper();

    Console.Write("Iveskite raktazodi, kuri naudosime: ");
    raktazodis = Console.ReadLine().ToUpper();
 
    string rakt = raktas(tekstas, raktazodis);
    string cipher_text = cipherText(tekstas, rakt);
 
    Console.WriteLine("\nUzkoduotas tekstas : "
        + cipher_text + "\n");
 
    Console.WriteLine("Dekriptintas tekstas : "
        + tekst(cipher_text, rakt));
    }
}