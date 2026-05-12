using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryFour;

namespace WinFormsAppFour
{
   public partial class PersonEditDialog : Form
   {
      public Person CreatedPerson { get; private set; }
      private Person _editPerson;


      public PersonEditDialog(Person editPerson = null)
      {
         InitializeComponent();

         _editPerson = editPerson;

         if (_editPerson != null)
         {
            txtName.Text = _editPerson.Name;
            dtpBirth.Value = _editPerson.BirthDate;
            numSalary.Value = _editPerson.Salary;
            txtSkills.Text = string.Join(", ", _editPerson.Skills);
         }
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtName.Text))
         {
            MessageBox.Show(@"Введите имя!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         if (_editPerson != null)
         {
            // Редактирование существующего
            _editPerson.Name = txtName.Text;
            _editPerson.BirthDate = dtpBirth.Value;
            _editPerson.Salary = numSalary.Value;
            _editPerson.Skills.Clear();
            for (int index = 0; index < txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length; index++)
            {
               string skill = txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[index];
               _editPerson.Skills.Add(skill.Trim());
            }

            CreatedPerson = _editPerson;
         }

         DialogResult = DialogResult.OK;
         Close();
      }
   }
}
