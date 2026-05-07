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
      public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();

      public override string ToString()
      {
         return $"[{Id}] {Name} ({BirthDate:yyyy-MM-dd}) - ЗП: {Salary:C} - Навыки: {string.Join(", ", Skills)}";
      }
   }
}