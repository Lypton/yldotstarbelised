using System;
namespace Lapid2{
    /// <summary>
    /// Lappide hoiustamise klass
    /// </summary>
   class Lapp{
       /// <summary>
       ///    Muutuja ainult lugemiseks. 
       ///    Andmed sisestatavad vaid konstruktoris.
       /// </summary>
       private int x;
       private int y;
       private string z;

       /// <summary>
       ///    Lapi algandmed
       /// </summary>
       public Lapp(int ux, int uy, string uz){
         x=ux; 
         y=uy; 
         z=uz;
       }
       public string GetColor(){
         return z;
       }

       /// <summary>
       ///    Arvutab pindala
       /// </summary>
       public double Pindala(){
         if(x == y) {
           return (x*y);
         } else {
           return (x*y/2);
         }
       }
   }
   
       /// <summary>
       ///    Proovklass
       /// </summary>
   class Lapiproov{
     public static void Main(string[] arg){
         Lapp lapp_1=new Lapp(3, 6, "must");
         Console.WriteLine("Lapi pindala on " + lapp_1.Pindala() + ". Värv on " + lapp_1.GetColor());
     }
   }
}