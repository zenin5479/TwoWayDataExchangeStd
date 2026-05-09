namespace WinFormsAppFour
{
   partial class FormFour
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         panelTop = new System.Windows.Forms.Panel();
         panelBottom = new System.Windows.Forms.Panel();
         dgvPeople = new System.Windows.Forms.DataGridView();
         btnAddPerson = new System.Windows.Forms.Button();
         btnRunConsole = new System.Windows.Forms.Button();
         btnDeleteSelected = new System.Windows.Forms.Button();
         btnEditSelected = new System.Windows.Forms.Button();
         label1 = new System.Windows.Forms.Label();
         lblAvgSalary = new System.Windows.Forms.Label();
         lblConsoleMessage = new System.Windows.Forms.Label();
         panelTop.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
         SuspendLayout();
         // 
         // panelTop
         // 
         panelTop.Controls.Add(btnAddPerson);
         panelTop.Controls.Add(btnRunConsole);
         panelTop.Controls.Add(btnDeleteSelected);
         panelTop.Controls.Add(btnEditSelected);
         panelTop.Location = new System.Drawing.Point(12, 168);
         panelTop.Name = "panelTop";
         panelTop.Size = new System.Drawing.Size(194, 90);
         panelTop.TabIndex = 0;
         // 
         // panelBottom
         // 
         panelBottom.Location = new System.Drawing.Point(245, 197);
         panelBottom.Name = "panelBottom";
         panelBottom.Size = new System.Drawing.Size(200, 100);
         panelBottom.TabIndex = 1;
         // 
         // dgvPeople
         // 
         dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvPeople.Location = new System.Drawing.Point(12, 12);
         dgvPeople.Name = "dgvPeople";
         dgvPeople.RowTemplate.Height = 25;
         dgvPeople.Size = new System.Drawing.Size(200, 150);
         dgvPeople.TabIndex = 2;
         // 
         // btnAddPerson
         // 
         btnAddPerson.Location = new System.Drawing.Point(3, 32);
         btnAddPerson.Name = "btnAddPerson";
         btnAddPerson.Size = new System.Drawing.Size(90, 23);
         btnAddPerson.TabIndex = 3;
         btnAddPerson.Text = "➕ Добавить";
         btnAddPerson.UseVisualStyleBackColor = true;
         // 
         // btnRunConsole
         // 
         btnRunConsole.Location = new System.Drawing.Point(3, 3);
         btnRunConsole.Name = "btnRunConsole";
         btnRunConsole.Size = new System.Drawing.Size(135, 23);
         btnRunConsole.TabIndex = 4;
         btnRunConsole.Text = "▶ Запустить консоль";
         btnRunConsole.UseVisualStyleBackColor = true;
         // 
         // btnDeleteSelected
         // 
         btnDeleteSelected.Location = new System.Drawing.Point(99, 32);
         btnDeleteSelected.Name = "btnDeleteSelected";
         btnDeleteSelected.Size = new System.Drawing.Size(90, 23);
         btnDeleteSelected.TabIndex = 5;
         btnDeleteSelected.Text = "🗑 Удалить";
         btnDeleteSelected.UseVisualStyleBackColor = true;
         // 
         // btnEditSelected
         // 
         btnEditSelected.Location = new System.Drawing.Point(3, 61);
         btnEditSelected.Name = "btnEditSelected";
         btnEditSelected.Size = new System.Drawing.Size(125, 23);
         btnEditSelected.TabIndex = 6;
         btnEditSelected.Text = "✏ Редактировать";
         btnEditSelected.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(461, 240);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(89, 15);
         label1.TabIndex = 7;
         label1.Text = "Всего людей: 0";
         // 
         // lblAvgSalary
         // 
         lblAvgSalary.AutoSize = true;
         lblAvgSalary.Location = new System.Drawing.Point(493, 303);
         lblAvgSalary.Name = "lblAvgSalary";
         lblAvgSalary.Size = new System.Drawing.Size(84, 15);
         lblAvgSalary.TabIndex = 8;
         lblAvgSalary.Text = "Средняя ЗП: 0";
         // 
         // lblConsoleMessage
         // 
         lblConsoleMessage.AutoSize = true;
         lblConsoleMessage.Location = new System.Drawing.Point(421, 364);
         lblConsoleMessage.Name = "lblConsoleMessage";
         lblConsoleMessage.Size = new System.Drawing.Size(38, 15);
         lblConsoleMessage.TabIndex = 9;
         lblConsoleMessage.Text = "label2";
         // 
         // FormFour
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(768, 471);
         Controls.Add(lblConsoleMessage);
         Controls.Add(lblAvgSalary);
         Controls.Add(label1);
         Controls.Add(dgvPeople);
         Controls.Add(panelBottom);
         Controls.Add(panelTop);
         Name = "FormFour";
         Text = "Система обмена данными с консолью";
         panelTop.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Panel panelTop;
      private System.Windows.Forms.Panel panelBottom;
      private System.Windows.Forms.DataGridView dgvPeople;
      private System.Windows.Forms.Button btnAddPerson;
      private System.Windows.Forms.Button btnRunConsole;
      private System.Windows.Forms.Button btnDeleteSelected;
      private System.Windows.Forms.Button btnEditSelected;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblAvgSalary;
      private System.Windows.Forms.Label lblConsoleMessage;
   }
}