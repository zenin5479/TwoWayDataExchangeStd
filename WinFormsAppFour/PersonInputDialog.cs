using System;
using System.Linq;
using ClassLibraryFour;
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

      private void btnOk_Click(object sender, System.EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtName.Text))
         {
            MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         if (_editPerson != null)
         {
            // Редактирование существующего
            _editPerson.Name = txtName.Text;
            _editPerson.BirthDate = dtpBirth.Value;
            _editPerson.Salary = numSalary.Value;
            _editPerson.Skills.Clear();
            foreach (var skill in txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
               _editPerson.Skills.Add(skill.Trim());
            CreatedPerson = _editPerson;
         }
         else
         {
            // Создание нового
            CreatedPerson = new Person
            {
               Name = txtName.Text,
               BirthDate = dtpBirth.Value,
               Salary = numSalary.Value,
               Skills = txtSkills.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(s => s.Trim()).ToList()
            };
         }

         DialogResult = DialogResult.OK;
         Close();
      }
   }
}