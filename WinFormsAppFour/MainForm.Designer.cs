namespace WinFormsAppFour
{
   partial class MainForm
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
         btnAddPerson = new System.Windows.Forms.Button();
         btnRunConsole = new System.Windows.Forms.Button();
         btnDeleteSelected = new System.Windows.Forms.Button();
         btnEditSelected = new System.Windows.Forms.Button();
         panelBottom = new System.Windows.Forms.Panel();
         lblConsoleMessage = new System.Windows.Forms.Label();
         lblTotalCount = new System.Windows.Forms.Label();
         lblAvgSalary = new System.Windows.Forms.Label();
         dgvPeople = new System.Windows.Forms.DataGridView();
         Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         panelTop.SuspendLayout();
         panelBottom.SuspendLayout();
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
         // btnAddPerson
         // 
         btnAddPerson.Location = new System.Drawing.Point(3, 32);
         btnAddPerson.Name = "btnAddPerson";
         btnAddPerson.Size = new System.Drawing.Size(90, 23);
         btnAddPerson.TabIndex = 3;
         btnAddPerson.Text = "➕ Добавить";
         btnAddPerson.UseVisualStyleBackColor = true;
         btnAddPerson.Click += btnAddPerson_Click;
         // 
         // btnRunConsole
         // 
         btnRunConsole.Location = new System.Drawing.Point(3, 3);
         btnRunConsole.Name = "btnRunConsole";
         btnRunConsole.Size = new System.Drawing.Size(135, 23);
         btnRunConsole.TabIndex = 4;
         btnRunConsole.Text = "▶ Запустить консоль";
         btnRunConsole.UseVisualStyleBackColor = true;
         btnRunConsole.Click += btnRunConsole_Click;
         // 
         // btnDeleteSelected
         // 
         btnDeleteSelected.Location = new System.Drawing.Point(99, 32);
         btnDeleteSelected.Name = "btnDeleteSelected";
         btnDeleteSelected.Size = new System.Drawing.Size(90, 23);
         btnDeleteSelected.TabIndex = 5;
         btnDeleteSelected.Text = "🗑 Удалить";
         btnDeleteSelected.UseVisualStyleBackColor = true;
         btnDeleteSelected.Click += btnDeleteSelected_Click;
         // 
         // btnEditSelected
         // 
         btnEditSelected.Location = new System.Drawing.Point(3, 61);
         btnEditSelected.Name = "btnEditSelected";
         btnEditSelected.Size = new System.Drawing.Size(125, 23);
         btnEditSelected.TabIndex = 6;
         btnEditSelected.Text = "✏ Редактировать";
         btnEditSelected.UseVisualStyleBackColor = true;
         btnEditSelected.Click += btnEditSelected_Click;
         // 
         // panelBottom
         // 
         panelBottom.Controls.Add(lblConsoleMessage);
         panelBottom.Controls.Add(lblTotalCount);
         panelBottom.Controls.Add(lblAvgSalary);
         panelBottom.Location = new System.Drawing.Point(212, 168);
         panelBottom.Name = "panelBottom";
         panelBottom.Size = new System.Drawing.Size(177, 63);
         panelBottom.TabIndex = 1;
         // 
         // lblConsoleMessage
         // 
         lblConsoleMessage.AutoSize = true;
         lblConsoleMessage.Location = new System.Drawing.Point(3, 41);
         lblConsoleMessage.Name = "lblConsoleMessage";
         lblConsoleMessage.Size = new System.Drawing.Size(96, 15);
         lblConsoleMessage.TabIndex = 3;
         lblConsoleMessage.Text = "ConsoleMessage";
         // 
         // lblTotalCount
         // 
         lblTotalCount.AutoSize = true;
         lblTotalCount.Location = new System.Drawing.Point(3, 11);
         lblTotalCount.Name = "lblTotalCount";
         lblTotalCount.Size = new System.Drawing.Size(89, 15);
         lblTotalCount.TabIndex = 7;
         lblTotalCount.Text = "Всего людей: 0";
         // 
         // lblAvgSalary
         // 
         lblAvgSalary.AutoSize = true;
         lblAvgSalary.Location = new System.Drawing.Point(3, 26);
         lblAvgSalary.Name = "lblAvgSalary";
         lblAvgSalary.Size = new System.Drawing.Size(84, 15);
         lblAvgSalary.TabIndex = 8;
         lblAvgSalary.Text = "Средняя ЗП: 0";
         // 
         // dgvPeople
         // 
         dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
         dgvPeople.Location = new System.Drawing.Point(12, 12);
         dgvPeople.Name = "dgvPeople";
         dgvPeople.RowTemplate.Height = 25;
         dgvPeople.Size = new System.Drawing.Size(679, 150);
         dgvPeople.TabIndex = 2;
         // 
         // Column1
         // 
         Column1.HeaderText = "Id";
         Column1.Name = "Column1";
         Column1.Width = 50;
         // 
         // Column2
         // 
         Column2.HeaderText = "Name";
         Column2.Name = "Column2";
         Column2.Width = 150;
         // 
         // Column3
         // 
         Column3.HeaderText = "BirthDate";
         Column3.Name = "Column3";
         // 
         // Column4
         // 
         Column4.HeaderText = "Salary";
         Column4.Name = "Column4";
         // 
         // Column5
         // 
         Column5.HeaderText = "Skills";
         Column5.Name = "Column5";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(801, 270);
         Controls.Add(dgvPeople);
         Controls.Add(panelBottom);
         Controls.Add(panelTop);
         Name = "MainForm";
         Text = "Система обмена данными с консолью";
         Load += FormFour_Load;
         panelTop.ResumeLayout(false);
         panelBottom.ResumeLayout(false);
         panelBottom.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.Panel panelTop;
      private System.Windows.Forms.Panel panelBottom;
      private System.Windows.Forms.DataGridView dgvPeople;
      private System.Windows.Forms.Button btnAddPerson;
      private System.Windows.Forms.Button btnRunConsole;
      private System.Windows.Forms.Button btnDeleteSelected;
      private System.Windows.Forms.Button btnEditSelected;
      private System.Windows.Forms.Label lblTotalCount;
      private System.Windows.Forms.Label lblAvgSalary;
      private System.Windows.Forms.Label lblConsoleMessage;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
   }
}