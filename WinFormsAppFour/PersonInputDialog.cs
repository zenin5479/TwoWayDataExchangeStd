using ClassLibraryFour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppFour
{
   public partial class PersonInputDialog : Form
   {
      public Person CreatedPerson { get; private set; }
      private Person _editPerson;

      public PersonInputDialog(Person editPerson = null)
      {
         InitializeComponent();

         _editPerson = editPerson;
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtName.Text))
         {
            MessageBox.Show(@"Введите имя!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         if (_editPerson == null)
         {
            // Создание нового
            List<string> list = new List<string>();
            for (var index = 0; index < txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length; index++)
            {
               string s = txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[index];
               list.Add(s.Trim());
            }

            CreatedPerson = new Person
            {
               Name = txtName.Text,
               BirthDate = dtpBirth.Value,
               Salary = numSalary.Value,
               Skills = list
            };
         }

         DialogResult = DialogResult.OK;
         Close();
      }
   }
}