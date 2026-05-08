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
            int i = 0;
            while (i < GlobalStorage.AllPeople.Count)
            {
               Person person = GlobalStorage.AllPeople[i];
               Console.WriteLine("  {0}", person);
               i++;
            }
         }

         // Выполняем операции над глобальными данными
         Console.WriteLine("\nВыполняем операции");

         // 1. Добавляем нового человека из консоли
         Person newPerson = new Person
         {
            Name = "Консольный Пользователь",
            BirthDate = new DateTime(1985, 5, 15),
            Salary = 75000,
            Skills = { "C#", "Консоль", "DLL-интеграция" },
            Attributes = { { "Отдел", "IT" }, { "Город", "Москва" } }
         };

         GlobalStorage.AddPerson(newPerson);
         Console.WriteLine("Добавлен: {0}", newPerson.Name);

         // 2. Обновляем данные существующих (добавляем бонус к зарплате)
         if (GlobalStorage.AllPeople.Count > 1)
         {
            int i = 0;
            while (i < GlobalStorage.AllPeople.Count)
            {
               Person person = GlobalStorage.AllPeople[i];
               if (person.Id != newPerson.Id)
               {
                  person.Salary += 5000;
                  Console.WriteLine("{0} получил бонус +5000", person.Name);
               }

               i++;
            }

            for ( )
            {

            }
         }

         // 3. Записываем сообщение для WinForms
         GlobalStorage.LastConsoleOutput =
            string.Format("Консоль завершила работу. Добавлен 1 человек, обновлено {0} человек(а). Всего: {1}",
               GlobalStorage.AllPeople.Count - 1, GlobalStorage.TotalPeopleCount);

         Console.WriteLine("\nИТОГО: {0} человек в хранилище", GlobalStorage.TotalPeopleCount);
         Console.WriteLine("\nНажмите Enter для завершения...");
         Console.ReadLine();
      }
   }
}