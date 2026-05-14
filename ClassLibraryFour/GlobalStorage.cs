using System.Collections.Generic;

namespace ClassLibraryFour
{
   public static class GlobalStorage
   {
      // Основное хранилище сложных данных
      public static List<Person> AllPeople { get; set; } = new List<Person>();

      // Счётчик для генерации ID
      private static int _nextId = 1;

      // Вспомогательный метод для добавления
      public static void AddPerson(Person person)
      {
         person.Id = _nextId++;
         AllPeople.Add(person);
      }

      // Данные для обмена между приложениями
      public static string LastConsoleOutput { get; set; }

      // Статистика
      public static int TotalPeopleCount
      {
         get { return AllPeople.Count; }
      }
   }
}