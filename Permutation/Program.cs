using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Permutation
{

    static bool CheckPermutation(String text1, String text2)
    {

        int text_1_lenght = text1.Length;
        int text_2_lenght = text2.Length;
        //Okunan Degerlerin Uzunlukları alınır.

        if (text_1_lenght != text_2_lenght)//Uzunlukları karşılaştırılır.
            return false;
        char[] Char_text_1 = text1.ToCharArray();//string tipinde tanımlanan değişkenin içerisindeki veriyi karakterlere ayırıp char tipinde tanımlanmış bir diziye aktarır.
        char[] Char_text_2 = text2.ToCharArray();

        Array.Sort(Char_text_1);
        Array.Sort(Char_text_2);

        for (int i = 0; i < text_1_lenght; i++) //text 1 uzunluğu kadar dön
            if (Char_text_1[i] != Char_text_2[i]) //Dizi içerisindeki harfleri karşılaştırır eşit değilse False döner.
                return false;

        return true;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Enter first Word");
        String text1 = Console.ReadLine(); //Kullanıcıdan ilk kelime alınır
        Console.WriteLine("Enter Second Word");
        String text2 = Console.ReadLine(); //Kullanıcıdan ikinci kelime alınır.
        if (CheckPermutation(text1, text2))//Metoda elde edilen değerleri gönderir.
            Console.WriteLine(true); //permutasyon mevcut ise True döner
        else
            Console.WriteLine(false); //permutasyon mevcut değil ise False döner.

        Console.ReadKey();



    }
}
