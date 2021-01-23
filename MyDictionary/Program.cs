
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Adana");
            myDictionary.Add(2, "Adıyaman");
            myDictionary.Add(3, "Afyon");
            myDictionary.Add(4, "Ağrı");
            myDictionary.Add(5, "Amasya");
            myDictionary.Add(6, "Ankara");
            myDictionary.Add(7, "Antalya");
            myDictionary.Add(8, "Artvin");
            myDictionary.Add(9, "Aydin");
            myDictionary.Add(10, "Balıkesir");

            myDictionary.ListAll();
            Console.WriteLine("--------------------");

            Console.WriteLine("1-10 arasındaki plaka kodlu şehir adı öğrenmek için lütfen sayı giriniz.");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k <= 10 & 0 <= k)
            {
                Console.WriteLine(k + " Plaka kodlu şehir adı " + myDictionary.Values[k - 1]);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız...");
            }

        }
    }
}