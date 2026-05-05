using System.Windows.Forms;

namespace WinFormsAppThree
{
   public partial class FormThree : Form
   {
      private DataStorage _storage;
      private ConsoleThree _consoleThree;

      public FormThree()
      {
         InitializeComponent();

         _storage = new DataStorage();
         _consoleThree = new ConsoleThree(_storage);
      }

      private void btnStartConsole_Click(object sender, System.EventArgs e)
      {
         // Запускаем консольное приложение
         _consoleThree.Run();
         UpdateListBox();
      }

      private void btnShowSelected_Click(object sender, System.EventArgs e)
      {
         if (listBoxPeople.SelectedIndex != -1)
         {
            int index = listBoxPeople.SelectedIndex;
            Person person = _storage.GetPerson(index);

            if (person != null)
            {
               MessageBox.Show(string.Format("Имя: {0}\n", person.Name) + string.Format("Возраст: {0}\n", person.Age) +
                               string.Format("Город: {0}\n", person.Address.City) + string.Format("Улица: {0}\n", person.Address.Street) +
                               string.Format("Почтовый индекс: {0}", person.Address.PostalCode), @"Информация о человеке");
            }
         }
         else
         {
            MessageBox.Show(@"Выберите человека из списка.", @"Внимание");
         }
      }

      private void UpdateListBox()
      {
         listBoxPeople.Items.Clear();

         int i = 0;
         while (i < _storage.GetCount())
         {
            Person person = _storage.GetPerson(i);
            listBoxPeople.Items.Add(string.Format("{0}, {1} лет", person.Name, person.Age));
            i++;
         }

         for (  )
         {

         }
      }
   }
}