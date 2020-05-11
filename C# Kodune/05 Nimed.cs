using System;
class Nimed{
   public static void Main(string[] arg){
      Console.WriteLine("Sisesta esimene arv:");
      double number_1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Sisesta teine arv:");
      double number_2 = double.Parse(Console.ReadLine());
      Console.WriteLine((number_1 + number_2) / 2);
   }
}