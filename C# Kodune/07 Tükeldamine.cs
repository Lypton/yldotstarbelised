using System;
class Tükeldamine{
   public static void Main(string[] arg){
            Console.WriteLine("Sisesta nimi, mida soovid tükeldada: ");
            String name =Console.ReadLine();
            int i = name.Length - 2;
            Console.WriteLine(i);
            Console.WriteLine(name[i]);
        }

   }
