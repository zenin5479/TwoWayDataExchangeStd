using System.Collections.Generic;
using System;

namespace WinFormsAppThree
{
   internal class DataStorage
   {
      public List<Person> People { get; set; } = new List<Person>();

      public void AddPerson(Person person)
      {
         People.Add(person);
      }

      public Person GetPerson(int index)
      {
         if (index >= 0 && index < People.Count)
            return People[index];
         return null;
      }

      public int GetCount()
      {
         return People.Count;
      }
   }
}