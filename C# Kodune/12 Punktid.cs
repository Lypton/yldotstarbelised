using System;
namespace Punktid{
   class Punkt{
       private int x;
       private int y;
       public Punkt(int ux, int uy){
         x=ux; 
         y=uy;
       }
       public int GetX(){
         return x;
       }
       public int GetY(){
         return y.Value;
       }
   }
   class Punktiproov{
     public static void Main(string[] arg){
         Console.WriteLine("Sisesta mitu soovid lisada: ");
         int lappide_arv = int.Parse(Console.ReadLine());
         Punkt[] pd = new Punkt[lappide_arv];
         for(int i=0; i<lappide_arv; i++){
            Console.WriteLine("Sisesta lapi pikkus: ");
            int lapipikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta lapi laius: ");
            int lapilaius = int.Parse(Console.ReadLine());
            pd[i]=new Punkt(lapipikkus, lapilaius);
         }
        double pindalad = 0;
         for(int j=0; j<lappide_arv; j++){
            pindalad = pindalad + (pd[j].GetX.Value * pd[j].GetY.Value / 2);
     }
   }
}
}