using System;
namespace Parilus{
 class Person{
   protected int age;
   public Person(int uage){
      age=uage;
   }
   public virtual void TellAge(){
      Console.WriteLine("Vanus on "+age+" aastat");
   }
   
   public virtual void Calling(){
     Console.WriteLine("Ettekandja, palun tulge siia!");
   }
 }
 class Lady:Person {
   public Lady(int age):base(age){}
   public override void TellAge(){
      Console.WriteLine("Minu age on "+(age-5)+" aastat");   
   }
 }
 class Testing{
  public static void Main(string[] arg){
     Person person_1 = new Person(40);
     Lady person_2 = new Lady(40);
     person_1.TellAge();
     person_2.TellAge();
     person_2.Calling();
  }
 }
}