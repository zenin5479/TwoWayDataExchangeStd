namespace WinFormsAppFour
{
   partial class PersonInputDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         dtpBirth = new System.Windows.Forms.DateTimePicker();
         label1 = new System.Windows.Forms.Label();
         txtName = new System.Windows.Forms.TextBox();
         numSalary = new System.Windows.Forms.NumericUpDown();
         txtSkills = new System.Windows.Forms.TextBox();
         btnOk = new System.Windows.Forms.Button();
         btnCancel = new System.Windows.Forms.Button();
         label2 = new System.Windows.Forms.Label();
         label3 = new System.Windows.Forms.Label();
         label4 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
         SuspendLayout();
         // 
         // dtpBirth
         // 
         dtpBirth.Location = new System.Drawing.Point(111, 41);
         dtpBirth.Name = "dtpBirth";
         dtpBirth.Size = new System.Drawing.Size(200, 23);
         dtpBirth.TabIndex = 0;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(12, 15);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(34, 15);
         label1.TabIndex = 1;
         label1.Text = "Имя:";
         // 
         // txtName
         // 
         txtName.Location = new System.Drawing.Point(52, 12);
         txtName.Name = "txtName";
         txtName.Size = new System.Drawing.Size(259, 23);
         txtName.TabIndex = 2;
         // 
         // numSalary
         // 
         numSalary.Location = new System.Drawing.Point(79, 70);
         numSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
         numSalary.Name = "numSalary";
         numSalary.Size = new System.Drawing.Size(232, 23);
         numSalary.TabIndex = 3;
         // 
         // txtSkills
         // 
         txtSkills.Location = new System.Drawing.Point(71, 99);
         txtSkills.Name = "txtSkills";
         txtSkills.PlaceholderText = "C#, SQL, Python (через запятую)";
         txtSkills.Size = new System.Drawing.Size(240, 23);
         txtSkills.TabIndex = 4;
         // 
         // btnOk
         // 
         btnOk.Location = new System.Drawing.Point(12, 128);
         btnOk.Name = "btnOk";
         btnOk.Size = new System.Drawing.Size(75, 23);
         btnOk.TabIndex = 5;
         btnOk.Text = "Добавить";
         btnOk.UseVisualStyleBackColor = true;
         btnOk.Click += btnOk_Click;
         // 
         // btnCancel
         // 
         btnCancel.Location = new System.Drawing.Point(93, 128);
         btnCancel.Name = "btnCancel";
         btnCancel.Size = new System.Drawing.Size(75, 23);
         btnCancel.TabIndex = 6;
         btnCancel.Text = "Отмена";
         btnCancel.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new System.Drawing.Point(12, 47);
         label2.Name = "label2";
         label2.Size = new System.Drawing.Size(93, 15);
         label2.TabIndex = 7;
         label2.Text = "Дата рождения:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new System.Drawing.Point(12, 72);
         label3.Name = "label3";
         label3.Size = new System.Drawing.Size(61, 15);
         label3.TabIndex = 8;
         label3.Text = "Зарплата:";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new System.Drawing.Point(12, 102);
         label4.Name = "label4";
         label4.Size = new System.Drawing.Size(53, 15);
         label4.TabIndex = 9;
         label4.Text = "Навыки:";
         // 
         // PersonInputDialog
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(327, 163);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(btnCancel);
         Controls.Add(btnOk);
         Controls.Add(txtSkills);
         Controls.Add(numSalary);
         Controls.Add(txtName);
         Controls.Add(label1);
         Controls.Add(dtpBirth);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "PersonInputDialog";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Редактирование человека";
         ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.DateTimePicker dtpBirth;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.NumericUpDown numSalary;
      private System.Windows.Forms.TextBox txtSkills;
      private System.Windows.Forms.Button btnOk;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}