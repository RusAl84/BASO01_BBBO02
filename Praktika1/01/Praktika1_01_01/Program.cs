using System;

namespace Praktika1_01_01
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;
      static string secret;

      public Person(string firstName, string lastName, int age)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        secret = "ВАЗЕЛИН";
      }

      public override string ToString()
      {
        return $"Фамилия: {this.lastName}  Имя: {this.firstName} ест {secret}" ;
      }


       public void setSecret(string str1)
      {
        secret = str1;
      }
    }

    static void Main(string[] args)
    {

      Person p1 = new Person("Mersov", "Andrey", 66); 
      Person p2 = new Person("Русаков", "Алексей", 36); 
      p2.setSecret("Ёжика");
      Console.WriteLine(p1);
      Console.WriteLine(p2);
    }
  }
}
