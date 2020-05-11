using System;

public class Juhuarv{
   public static void Main(string[] arg){
      Random random_number =new Random();
      while(true){
      int number = random_number.Next(10);
      Console.WriteLine("Arva suvaline number!");
      int guess = int.Parse(Console.ReadLine());
      if(guess == number) {
        Console.WriteLine("Õige number!");
        break;
      } else {
        Console.WriteLine("Vale number! Proovi uuesti!");
      }
     }
   }
}