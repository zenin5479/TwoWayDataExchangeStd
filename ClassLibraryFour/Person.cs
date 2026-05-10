using System;
using System.Collections.Generic;

namespace ClassLibraryFour
{
   public class Person
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public DateTime BirthDate { get; set; }
      public decimal Salary { get; set; }
      public List<string> Skills { get; set; } = new List<string>();

      public override string ToString()
      {
         return string.Format("[{0}] {1} ({2:yyyy-MM-dd}) - ЗП: {3:C} - Навыки: {4}", Id, Name, BirthDate, Salary,
            string.Join(", ", Skills));
      }
   }
}