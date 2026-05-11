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

         //// Абсолютный путь к файлу
         //Console.WriteLine("Абсолютный путь к файлу в console application");
         //// 1 вариант 
         //string path1 = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
         //Console.WriteLine(path1);
         //// 2 вариант 
         //string path2 = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
         //Console.WriteLine(path2);
         //// 3 вариант 
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
         //string path6 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
         //Console.WriteLine(path6);
         //// 7 вариант 
         //if (AppDomain.CurrentDomain.BaseDirectory != null)
         //{
         //   string path7 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
         //   Console.WriteLine(path7);
         //}




         // Находим путь к консольному EXE
         string fileName = "ConsoleAppFour.exe";
         string consolePath = Path.GetFullPath(fileName);

         if (!File.Exists(consolePath))
         {
            MessageBox.Show(
               string.Format(@"Не найден ConsoleAppFour.exe по пути:{0} Укажите правильный путь!", consolePath),
               @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
         if (dgvPeople.CurrentRow == null)
         {
            return;
         }

         Person person = (Person)dgvPeople.CurrentRow.Tag;
         if (person != null)
         {
            if (MessageBox.Show(string.Format(@"Удалить {0}?", person.Name), @"Подтверждение",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               GlobalStorage.AllPeople.Remove(person);
               // Обновляем строку в DataGrid
               RefreshDataGrid();
               // Обновляем статусную строку
               UpdateStatus(); // если есть статусная строка
            }
         }
      }

      private void btnEditSelected_Click(object sender, EventArgs e)
      {
         if (dgvPeople.CurrentRow == null)
         {
            return;
         }

         Person person = (Person)dgvPeople.CurrentRow.Tag;
         if (person != null)
         {
            using (var editDialog = new PersonEditDialog(person))
            {
               if (editDialog.ShowDialog() == DialogResult.OK)
               {
                  // Обновляем строку в DataGrid
                  RefreshDataGrid();
                  // Обновляем статусную строку
                  UpdateStatus();
               }
            }
         }
      }

      private void RefreshDataGrid()
      {
         // Очищаем все строки
         dgvPeople.Rows.Clear();

         // Перебираем всех людей из хранилища
         for (int index = 0; index < GlobalStorage.AllPeople.Count; index++)
         {
            Person person = GlobalStorage.AllPeople[index];
            // Добавляем новую строку и заполняем ячейки по индексу или имени колонки
            int rowIndex = dgvPeople.Rows.Add();
            DataGridViewRow row = dgvPeople.Rows[rowIndex];

            row.Cells[0].Value = person.Id;
            row.Cells[1].Value = person.Name;
            row.Cells[2].Value = person.BirthDate.ToShortDateString();
            row.Cells[3].Value = person.Salary;
            row.Cells[4].Value = string.Join(", ", person.Skills);
            // Сохраняем сам объект в Tag строки
            row.Tag = person;
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