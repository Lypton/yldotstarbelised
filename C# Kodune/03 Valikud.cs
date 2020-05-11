using System;
public class Valikud{
   public static void Main(string[] arg){
      int normal_temperature = 20;
      Console.WriteLine("Sisesta oma toatemperatuur: ");
      int temperature = int.Parse(Console.ReadLine());
      if(temperature < normal_temperature){
         Console.WriteLine("Teie toatemperatuur on väiksem soovitatavast temperatuurist.");
      } else if(temperature > normal_temperature) {
        Console.WriteLine("Teie toatemperatuur on suurem soovitatavast temperatuurist.");
      } else if(temperature == normal_temperature) {
        Console.WriteLine("Teie toatemperatuur on perfektne!");
      } 
      
   }
}