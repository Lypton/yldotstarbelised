using System;
namespace Liides{
 class Person{
   protected int age;
   public Person(int uage){
      age=uage;
   }
   public virtual void TellAge(){
      Console.WriteLine("Enda vanus on "+age+" .");
   }

 }
 interface Inteligence{
   void Welcoming(String familiar);

   void Knocking(String familiar);
 }
 class Laps:Person, Inteligence {
   public Laps(int age):base(age){}
   public void Welcoming(String familiar){
     Console.WriteLine("Tere, "+familiar);
   }
  public void Knocking(String familiar) {
     Console.WriteLine("Koputan " +familiar + " uksele!");
   }
 }
 class Dog: Inteligence{
   public void Welcoming(String familiar){
      Console.WriteLine("Auf!");
   }

   public void Knocking(String familiar) {
     Console.WriteLine("Auf!");
   }
 }
 class Testing{
  static void Birthday(Inteligence v){
     v.Knocking("Grandmother");
     v.Welcoming("Grandmother");
  }
  public static void Main(string[] arg){
     Laps James =new Laps(6);
     James.TellAge();
     Dog Roxi =new Dog();
     Birthday(James);
     Birthday(Roxi);
  }
 }
}