using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Recursive - Öz yinelemeli

           //3^4
           int result=1;
           for (int i = 1; i <5; i++)
           {
            result=result*3;
           }
           Console.WriteLine(result);

           Islemler ıslemler=new Islemler();
           Console.WriteLine(ıslemler.Expo(3,4));

           //Extension Metotlar
           string ifade="Ayça Doğan";
           bool sonuc=ifade.CheckSpace();
           Console.WriteLine(sonuc);

           if(sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpperCase());

            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi=5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
                return sayi;
            return Expo(sayi,us-1)*3;
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi=param.Split(" ");  
            return string.Join("",dizi);          

        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
              Console.WriteLine(item);  
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }

}
