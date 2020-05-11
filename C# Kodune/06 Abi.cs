using System;
class Abiproov{
   public static void Main(string[] arg){
       while(true) {
            Console.WriteLine("Sisesta arv astendamiseks: ");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta arvule antud astendaja: ");
            int number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Abiproov.astenda(number_1, number_2));
            Console.WriteLine("Kas soovid jätkata? (Jah/Ei)");
            String continue = Console.ReadLine();
            if(continue != "Jah") {
                break;
            }

        }

   }
}