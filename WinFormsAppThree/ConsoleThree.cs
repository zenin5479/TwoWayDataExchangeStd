using System;

namespace WinFormsAppThree
{
   internal class ConsoleThree
   {
      private DataStorage _storage;

      public ConsoleThree(DataStorage storage)
      {
         _storage = storage;
      }

      public void Run()
      {
         Console.WriteLine("Консольное приложение запущено. Введите данные нового человека:");

         while (true)
         {
            Console.Write("Имя (или 'exit' для выхода): ");
            string name = Console.ReadLine();

            if (name != null && name.ToLower() == "exit")
            {
               break;
            }

            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Город: ");
            string city = Console.ReadLine();
            Console.Write("Улица: ");
            string street = Console.ReadLine();
            Console.Write("Почтовый индекс: ");
            string postalCode = Console.ReadLine();

            var address = new Address
            {
               City = city,
               Street = street,
               PostalCode = postalCode
            };

            var person = new Person
            {
               Name = name,
               Age = age,
               Address = address
            };

            _storage.AddPerson(person);
            Console.WriteLine($"Человек '{name}' добавлен в хранилище.\n");
         }
      }
   }
}