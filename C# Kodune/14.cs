using System;
namespace Parilus{
 class Person{
   protected int age;
   protected int length;
   public Person(int uage, int ulength){
      age=uage; 
      length = ulength;
   }
   public void Tellage(){
      Console.WriteLine("Minu age on "+age+" aastat");
   }

   public void Telllength(){
      Console.WriteLine("Minu length on "+length+" sentimeetrit");
   }
 }
 class Model:Person {
   protected int circumference;
   public Model(int age,int length, int ucircumference):base(age, length){
      circumference=ucircumference; 
   }
   public void Show(){
      TellAge();
      TellLength();
      Console.WriteLine("Ümbermõõduks on "+circumference+" sentimeetrit");
   }
 }
 class Testing{
  public static void Main(string[] arg){
     Modell m = new Modell(20, 90, 180);
     m.Show();
  }
 }
}