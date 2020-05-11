using System;
namespace Lapid2{
   class Lapp{
       private int x;
       private int y;
       private string z;
       public Lapp(int ux, int uy, string uz){
         x=ux; 
         y=uy; 
         z=uz;
       }
       public string GetColor(){
         return z;
       }
       public double Pindala(){
         if(x == y) {
           return (x*y);
         } else {
           return (x*y/2);
         }
       }
   }
   class Lapiproov{
     public static void Main(string[] arg){
         Lapp lapp_1 = new Lapp(3, 6, "must");
         Console.WriteLine("Lapi pindala on " + lapp_1.Pindala() + ". Värv on " + lapp_1.GetColor());
     }
   }
}