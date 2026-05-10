using ClassLibraryFour;
using System;
using System.Collections.Generic;
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

         // Абсолютный путь к файлу
         // 3 вариант 
         //ProcessModule path3 = Process.GetCurrentProcess().MainModule;
         //if (path3 != null)
         //{
         //   string path30 = Path.GetDirectoryName(path3.FileName);
         //   Console.WriteLine(path30);
         //}
         //// 4 вариант 
         //string path4 = Directory.GetCurrentDirectory();
         //Console.WriteLine(path4);
         //// 5 вариант 
         //string path5 = AppContext.BaseDirectory;
         //Console.WriteLine(path5);
         //// 6 вариант 



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

         Person person = (Person)dgvPeople.CurrentRow.DataBoundItem;
         if (person != null)
         {
            if (MessageBox.Show(string.Format(@"Удалить {0}?", person.Name), @"Подтверждение",
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
         if (dgvPeople.CurrentRow == null)
         {
            return;
         }

         Person person = (Person)dgvPeople.CurrentRow.DataBoundItem;
         if (person != null)
         {
            using (PersonEditDialog editDialog = new PersonEditDialog(person))
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
         List<Person> list = new List<Person>();
         for (int i = 0; i < GlobalStorage.AllPeople.Count; i++)
         {
            Person person = GlobalStorage.AllPeople[i];
            list.Add(person);
         }

         dgvPeople.DataSource = list;

         //// Настройка колонок
         //if (dgvPeople.Columns.Count > 0)
         //{
         //   dgvPeople.Columns["Id"] = list.;
         //   dgvPeople.Columns["Name"].Width = 150;
         //   dgvPeople.Columns["BirthDate"].Width = 100;
         //   dgvPeople.Columns["Salary"].Width = 100;
         //   dgvPeople.Columns["Skills"].Visible = false;
         //   dgvPeople.Columns["Attributes"].Visible = false;

         //   dgvPeople.Columns["Salary"].DefaultCellStyle.Format = "C";
         //}

         //dgvPeople.SelectAll();
         //dgvPeople.ClearSelection();
         //dgvPeople.Rows.Clear();

         for (int i = 0; i < list.Count; ++i)
         {
            //dgvPeople.Columns["Id"][i] = list[i].Id;

            //dgvPeople.Columns["Id"][i] = list[i].Id;
            //dgvPeople.Columns["Name"].Width = 150;
            //dgvPeople.Columns["BirthDate"].Width = 100;
            //dgvPeople.Columns["Salary"].Width = 100;
            //dgvPeople.Columns["Skills"].Visible = false;
            //dgvPeople.Columns["Attributes"].Visible = false;

            //dgvPeople.Columns["Salary"].DefaultCellStyle.Format = "C";


            dgvPeople.Rows[i].Cells["Id"].Value = list[i].Id;
            dgvPeople.Rows[i].Cells["Name"].Value = list[i].Name;
            dgvPeople.Rows[i].Cells["BirthDate"].Value = list[i].BirthDate.ToShortDateString();
            dgvPeople.Rows[i].Cells["Skills"].Value = list[i].Salary;
            dgvPeople.Rows[i].Cells["Attributes"].Value = string.Join(", ", list[i].Skills);
         }


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