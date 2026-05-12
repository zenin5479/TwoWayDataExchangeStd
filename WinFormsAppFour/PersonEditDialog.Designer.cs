namespace WinFormsAppFour
{
   partial class PersonEditDialog
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
         label4 = new System.Windows.Forms.Label();
         label3 = new System.Windows.Forms.Label();
         label2 = new System.Windows.Forms.Label();
         btnCancel = new System.Windows.Forms.Button();
         btnOk = new System.Windows.Forms.Button();
         txtSkills = new System.Windows.Forms.TextBox();
         numSalary = new System.Windows.Forms.NumericUpDown();
         txtName = new System.Windows.Forms.TextBox();
         label1 = new System.Windows.Forms.Label();
         dtpBirth = new System.Windows.Forms.DateTimePicker();
         ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
         SuspendLayout();
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new System.Drawing.Point(12, 104);
         label4.Name = "label4";
         label4.Size = new System.Drawing.Size(53, 15);
         label4.TabIndex = 19;
         label4.Text = "Навыки:";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new System.Drawing.Point(12, 74);
         label3.Name = "label3";
         label3.Size = new System.Drawing.Size(61, 15);
         label3.TabIndex = 18;
         label3.Text = "Зарплата:";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new System.Drawing.Point(12, 49);
         label2.Name = "label2";
         label2.Size = new System.Drawing.Size(93, 15);
         label2.TabIndex = 17;
         label2.Text = "Дата рождения:";
         // 
         // btnCancel
         // 
         btnCancel.Location = new System.Drawing.Point(93, 130);
         btnCancel.Name = "btnCancel";
         btnCancel.Size = new System.Drawing.Size(75, 23);
         btnCancel.TabIndex = 16;
         btnCancel.Text = "Отмена";
         btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnOk
         // 
         btnOk.Location = new System.Drawing.Point(12, 130);
         btnOk.Name = "btnOk";
         btnOk.Size = new System.Drawing.Size(75, 23);
         btnOk.TabIndex = 15;
         btnOk.Text = "Сохранить";
         btnOk.UseVisualStyleBackColor = true;
         btnOk.Click += btnOk_Click;
         // 
         // txtSkills
         // 
         txtSkills.Location = new System.Drawing.Point(71, 101);
         txtSkills.Name = "txtSkills";
         txtSkills.PlaceholderText = "C#, SQL, Python (через запятую)";
         txtSkills.Size = new System.Drawing.Size(240, 23);
         txtSkills.TabIndex = 14;
         // 
         // numSalary
         // 
         numSalary.Location = new System.Drawing.Point(79, 72);
         numSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
         numSalary.Name = "numSalary";
         numSalary.Size = new System.Drawing.Size(232, 23);
         numSalary.TabIndex = 13;
         // 
         // txtName
         // 
         txtName.Location = new System.Drawing.Point(52, 14);
         txtName.Name = "txtName";
         txtName.Size = new System.Drawing.Size(259, 23);
         txtName.TabIndex = 12;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(12, 17);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(34, 15);
         label1.TabIndex = 11;
         label1.Text = "Имя:";
         // 
         // dtpBirth
         // 
         dtpBirth.Location = new System.Drawing.Point(111, 43);
         dtpBirth.Name = "dtpBirth";
         dtpBirth.Size = new System.Drawing.Size(200, 23);
         dtpBirth.TabIndex = 10;
         // 
         // PersonEditDialog
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(383, 166);
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
         Name = "PersonEditDialog";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Редактирование человека";
         ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOk;
      private System.Windows.Forms.TextBox txtSkills;
      private System.Windows.Forms.NumericUpDown numSalary;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DateTimePicker dtpBirth;
   }
}