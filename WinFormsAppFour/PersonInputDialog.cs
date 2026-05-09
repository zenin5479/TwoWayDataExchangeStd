using System;
using System.Windows.Forms;
using ClassLibraryFour;

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

         if (_editPerson != null)
         {
            Text = "Редактирование человека";
            txtName.Text = _editPerson.Name;
            dtpBirth.Value = _editPerson.BirthDate;
            numSalary.Value = _editPerson.Salary;
            txtSkills.Text = string.Join(", ", _editPerson.Skills);
            btnOk.Text = "Сохранить";
         }
         else
         {
            Text = "Добавление человека";
            btnOk.Text = "Добавить";
         }
      }

      private void InitializeComponent()
      {
         this.txtName = new System.Windows.Forms.TextBox();
         this.dtpBirth = new System.Windows.Forms.DateTimePicker();
         this.numSalary = new System.Windows.Forms.NumericUpDown();
         this.txtSkills = new System.Windows.Forms.TextBox();
         this.btnOk = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
         this.SuspendLayout();

         // label1
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 15);
         this.label1.Text = "Имя:";

         // txtName
         this.txtName.Location = new System.Drawing.Point(80, 12);
         this.txtName.Size = new System.Drawing.Size(250, 23);

         // label2
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 45);
         this.label2.Text = "Дата рождения:";

         // dtpBirth
         this.dtpBirth.Location = new System.Drawing.Point(80, 41);
         this.dtpBirth.Size = new System.Drawing.Size(250, 23);

         // label3
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 75);
         this.label3.Text = "Зарплата:";

         // numSalary
         this.numSalary.Location = new System.Drawing.Point(80, 71);
         this.numSalary.Maximum = 1000000;
         this.numSalary.Size = new System.Drawing.Size(250, 23);

         // label4
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 105);
         this.label4.Text = "Навыки:";

         // txtSkills
         this.txtSkills.Location = new System.Drawing.Point(80, 101);
         this.txtSkills.Size = new System.Drawing.Size(250, 23);
         this.txtSkills.PlaceholderText = "C#, SQL, Python (через запятую)";

         // btnOk
         this.btnOk.Location = new System.Drawing.Point(80, 140);
         this.btnOk.Size = new System.Drawing.Size(100, 30);
         this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);

         // btnCancel
         this.btnCancel.Location = new System.Drawing.Point(230, 140);
         this.btnCancel.Size = new System.Drawing.Size(100, 30);
         this.btnCancel.Text = "Отмена";
         this.btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

         this.ClientSize = new System.Drawing.Size(344, 186);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dtpBirth);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.numSalary);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtSkills);
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.btnCancel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.StartPosition = FormStartPosition.CenterParent;

         ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private void BtnOk_Click(object sender, EventArgs e)
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