using ClassLibraryFour;
using System;
using System.Linq;

namespace ConsoleAppFour
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("КОНСОЛЬНЫЙ ОБРАБОТЧИК");
         Console.WriteLine("Текущее количество людей в хранилище: {0}", GlobalStorage.TotalPeopleCount);

         // Показываем существующих людей
         if (GlobalStorage.AllPeople.Any())
         {
            Console.WriteLine("\nСуществующие люди:");
            for (int i = 0; i < GlobalStorage.AllPeople.Count; i++)
            {
               var person = GlobalStorage.AllPeople[i];
               Console.WriteLine($"  {person}");
            }
         }

         // Выполняем операции над глобальными данными
         Console.WriteLine("\n--- Выполняем операции ---");

         // 1. Добавляем нового человека из консоли
         var newPerson = new Person
         {
            Name = "Консольный Пользователь",
            BirthDate = new DateTime(1985, 5, 15),
            Salary = 75000,
            Skills = { "C#", "Консоль", "DLL-интеграция" },
            Attributes = { { "Отдел", "IT" }, { "Город", "Москва" } }
         };
         GlobalStorage.AddPerson(newPerson);
         Console.WriteLine($"✓ Добавлен: {newPerson.Name}");

         // 2. Обновляем данные существующих (добавляем бонус к зарплате)
         if (GlobalStorage.AllPeople.Count > 1)
         {
            foreach (var person in GlobalStorage.AllPeople.Where(p => p.Id != newPerson.Id))
            {
               person.Salary += 5000;
               Console.WriteLine($"✓ {person.Name} получил бонус +5000");
            }
         }

         // 3. Записываем сообщение для WinForms
         GlobalStorage.LastConsoleOutput = $"Консоль завершила работу. Добавлен 1 человек, обновлено {GlobalStorage.AllPeople.Count - 1} человек(а). Всего: {GlobalStorage.TotalPeopleCount}";

         Console.WriteLine($"\n--- ИТОГО: {GlobalStorage.TotalPeopleCount} человек в хранилище ---");
         Console.WriteLine("\nНажмите Enter для завершения...");
         Console.ReadLine();
      }
   }
}