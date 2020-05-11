using System;
class Arvutus{
   public static void Main(string[] arg){

      Console.WriteLine("Esimene arv:");
      string tekst1=Console.ReadLine();
      int arv1=int.Parse(tekst1);
      Console.WriteLine("Teine arv:");
      int arv2=int.Parse(Console.ReadLine());
      Console.WriteLine("Arvude {0} ja {1} korrutis on {2}", arv1, arv2, arv1*arv2);

      Console.WriteLine("Sisesta enda nimi:");
      string esimene=Console.ReadLine();
      Console.WriteLine("Sisesta kõrvalistuja nimi:");
      string teine=Console.ReadLine();
      Console.WriteLine(esimene+" ja "+teine);
   }
}
