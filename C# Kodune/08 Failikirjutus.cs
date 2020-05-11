using System;
using System.IO;
class Failikirjutus{
  public static void Main(string[] arg){
            FileStream f = new FileStream("kirjutus.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write_out = new StreamWriter(f);
            for(int number = 1; number <= 20; number++){
                write_out.WriteLine(number + "-" + number * number);
            }
            write_out.Close();     
  }
}