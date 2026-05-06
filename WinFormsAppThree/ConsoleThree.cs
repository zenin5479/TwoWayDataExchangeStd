using System;

namespace WinFormsAppThree
{
   public class ConsoleThree
   {
      private DataStorage _storage;

      public ConsoleThree(DataStorage storage)
      {
         _storage = storage;
      }

      public void Run()
      {
         Console.WriteLine(@"Консольное приложение запущено. Введите данные нового человека:");


         while (continueLoop)
         {
            Console.Write("Имя (или 'exit' для выхода): ");
            string name = Console.ReadLine();

            if (name?.ToLower() == "exit")
            {
               
            }
            else if (!string.IsNullOrWhiteSpace(name))
            {
               // Обработка остальных данных
               // ... код добавления в хранилище
            }
         }


         bool continueLoop = true;

         while (continueLoop)
         {
            Console.Write(@"Имя (или 'exit' для выхода): ");
            string name = Console.ReadLine();
            if (name != null && name.ToLower() == "exit")
            {
               // Устанавливаем флаг выхода
               continueLoop = false; 
            }



            Console.Write(@"Возраст: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int age))
            {
               Console.WriteLine(@"Ошибка: введённая строка не является числом!");
            }

            Console.Write(@"Город: ");
            string city = Console.ReadLine();
            Console.Write(@"Улица: ");
            string street = Console.ReadLine();
            Console.Write(@"Почтовый индекс: ");
            string postalCode = Console.ReadLine();

            Address address = new Address
            {
               City = city,
               Street = street,
               PostalCode = postalCode
            };

            Person person = new Person
            {
               Name = name,
               Age = age,
               Address = address
            };

            _storage.AddPerson(person);
            Console.WriteLine(@"Человек '{0}' добавлен в хранилище.", name);
         }
      }
   }
}