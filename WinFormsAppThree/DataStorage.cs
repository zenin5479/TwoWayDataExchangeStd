using System.Collections.Generic;

namespace WinFormsAppThree
{
   public class DataStorage
   {
      public List<Person> People { get; set; } = new List<Person>();

      public void AddPerson(Person person)
      {
         People.Add(person);
      }

      public Person GetPerson(int index)
      {
         if (index >= 0 && index < People.Count)
         {
            return People[index];
         }

         return null;
      }

      public int GetCount()
      {
         return People.Count;
      }
   }

   public class Person
   {
      public string Name { get; set; }
      public int Age { get; set; }
      public Address Address { get; set; }
   }

   public class Address
   {
      public string City { get; set; }
      public string Street { get; set; }
      public string PostalCode { get; set; }
   }
}