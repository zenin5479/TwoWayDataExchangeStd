using System.Windows.Forms;

namespace WinFormsAppThree
{
   public partial class FormThree : Form
   {
      private DataStorage _storage;
      private ConsoleAppThree _consoleAppThree;

      public FormThree()
      {
         InitializeComponent();

         _storage = new DataStorage();
         _consoleAppThree = new ConsoleAppThree(_storage);
      }

      private void btnStartConsole_Click(object sender, System.EventArgs e)
      {
         // Запускаем консольное приложение
         _consoleAppThree.Run();
         UpdateListBox();
      }

      private void btnShowSelected_Click(object sender, System.EventArgs e)
      {
         if (listBoxPeople.SelectedIndex != -1)
         {
            int index = listBoxPeople.SelectedIndex;
            var person = _storage.GetPerson(index);

            if (person != null)
            {
               MessageBox.Show(
                  $"Имя: {person.Name}\n" +
                  $"Возраст: {person.Age}\n" +
                  $"Город: {person.Address.City}\n" +
                  $"Улица: {person.Address.Street}\n" +
                  $"Почтовый индекс: {person.Address.PostalCode}",
                  "Информация о человеке"
               );
            }
         }
         else
         {
            MessageBox.Show("Выберите человека из списка.", "Внимание");
         }
      }

      private void UpdateListBox()
      {
         listBoxPeople.Items.Clear();
         for (int i = 0; i < _storage.GetCount(); i++)
         {
            var person = _storage.GetPerson(i);
            listBoxPeople.Items.Add($"{person.Name}, {person.Age} лет");
         }
      }
   }
}