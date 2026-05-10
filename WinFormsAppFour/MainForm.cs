using ClassLibraryFour;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppFour
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         RefreshDataGrid();
         UpdateStatus();
      }

      private void btnAddPerson_Click(object sender, EventArgs e)
      {
         using (PersonInputDialog inputDialog = new PersonInputDialog())
         {
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
               GlobalStorage.AddPerson(inputDialog.CreatedPerson);
               RefreshDataGrid();
               UpdateStatus();
               MessageBox.Show(string.Format(@"Человек {0} добавлен!", inputDialog.CreatedPerson.Name), @"Успех",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private void btnRunConsole_Click(object sender, EventArgs e)
      {
         // Находим путь к консольному EXE
         string consolePath = Path.Combine(
            Path.GetDirectoryName(Application.ExecutablePath),
            "..", "..", "..", "ConsoleAppFour", "bin", "Debug", "netcoreapp3.1", "ConsoleAppFour.exe");

         if (!File.Exists(consolePath))
         {
            MessageBox.Show($"Не найден ConsoleWorker.exe по пути:\n{consolePath}\n\nУкажите правильный путь!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // Запускаем консольное приложение синхронно
         Cursor = Cursors.WaitCursor;
         try
         {
            var process = new Process
            {
               StartInfo = new ProcessStartInfo
               {
                  FileName = consolePath,
                  UseShellExecute = false,
                  CreateNoWindow = true, // Без окна консоли
                  WindowStyle = ProcessWindowStyle.Hidden
               }
            };

            process.Start();
            process.WaitForExit();

            // После завершения консоли читаем обновлённые данные
            RefreshDataGrid();
            UpdateStatus();

            // Показываем сообщение от консоли
            if (!string.IsNullOrEmpty(GlobalStorage.LastConsoleOutput))
            {
               lblConsoleMessage.Text = GlobalStorage.LastConsoleOutput;
               MessageBox.Show(GlobalStorage.LastConsoleOutput, "Результат работы консоли",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         finally
         {
            Cursor = Cursors.Default;
         }
      }

      private void btnDeleteSelected_Click(object sender, EventArgs e)
      {
         if (dgvPeople.CurrentRow == null) return;

         var person = dgvPeople.CurrentRow.DataBoundItem as Person;
         if (person != null)
         {
            if (MessageBox.Show($"Удалить {person.Name}?", "Подтверждение",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               GlobalStorage.AllPeople.Remove(person);
               RefreshDataGrid();
               UpdateStatus();
            }
         }
      }

      private void btnEditSelected_Click(object sender, EventArgs e)
      {
         if (dgvPeople.CurrentRow == null) return;

         var person = dgvPeople.CurrentRow.DataBoundItem as Person;
         if (person != null)
         {
            using (var editDialog = new PersonEditDialog(person))
            {
               if (editDialog.ShowDialog() == DialogResult.OK)
               {
                  RefreshDataGrid();
                  UpdateStatus();
               }
            }
         }
      }

      private void RefreshDataGrid()
      {
         dgvPeople.DataSource = null;
         dgvPeople.DataSource = GlobalStorage.AllPeople.ToList();
      }

      private void UpdateStatus()
      {
         lblTotalCount.Text = string.Format(@"Всего людей: {0}", GlobalStorage.TotalPeopleCount);
         if (GlobalStorage.AllPeople.Any())
         {
            lblAvgSalary.Text = string.Format(@"Средняя ЗП: {0:C}", GlobalStorage.AllPeople.Average(p => p.Salary));
         }
         else
         {
            lblAvgSalary.Text = @"Средняя ЗП: 0";
         }
      }

      private void FormFour_Load(object sender, EventArgs e)
      {
         // Добавляем тестовые данные при первом запуске
         if (GlobalStorage.TotalPeopleCount == 0)
         {
            GlobalStorage.AddPerson(new Person
            {
               Name = "Лев Ткачук",
               BirthDate = new DateTime(1990, 5, 20),
               Salary = 87000,
               Skills = { "C#", "SQL" }
            });
            GlobalStorage.AddPerson(new Person
            {
               Name = "Татьяна Свиридова",
               BirthDate = new DateTime(1988, 12, 10),
               Salary = 99000,
               Skills = { "Java", "Python" }
            });
            GlobalStorage.AddPerson(new Person
            {
               Name = "Надежда Белова",
               BirthDate = new DateTime(1996, 10, 21),
               Salary = 119000,
               Skills = { "C++", "HTML" }
            });

            RefreshDataGrid();
            UpdateStatus();
         }
      }
   }
}