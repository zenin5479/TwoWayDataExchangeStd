using ClassLibraryFour;
using System;
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
         int index = 0;
         while (index < GlobalStorage.AllPeople.Count)
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
            index++;
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
               Salary = 119000,
               Skills = { "Java", "Python" }
            });
            GlobalStorage.AddPerson(new Person
            {
               Name = "Надежда Белова",
               BirthDate = new DateTime(1996, 10, 21),
               Salary = 137000,
               Skills = { "C++", "HTML" }
            });

            RefreshDataGrid();
            UpdateStatus();
         }
      }
   }
}