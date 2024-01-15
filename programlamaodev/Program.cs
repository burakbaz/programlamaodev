using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Başlangıç değeri: ");
        int baslangic = int.Parse(Console.ReadLine());

        Console.Write("Bitiş değeri: ");
        int bitis = int.Parse(Console.ReadLine());

        Console.Write("Oluşturulacak sayı adedi: ");
        int sayiAdedi = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        HashSet<int> essizsayilar = new HashSet<int>();

        while (essizsayilar.Count < sayiAdedi)
        {
            int rasgeleSayi = rnd.Next(baslangic, bitis + 1);
            essizsayilar.Add(rasgeleSayi);
        }

        int[] rasgeleSayilar = essizsayilar.ToArray();


        for (int i = 0; i < rasgeleSayilar.Length; i++)
        {
            Console.WriteLine(rasgeleSayilar[i]);
        }

        

    }
}