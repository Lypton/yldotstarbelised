using System;
namespace Indekseering1{
 class Kuubiarvutus{
   public int this[int number]{
      get{return number*number*number;}
   }
 }
 class Test{
  public static void Main(string[] arg){
     Kuubiarvutus r=new Kuubiarvutus();
     Console.WriteLine(r[3]);
  }
 }
}