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
         panel1 = new System.Windows.Forms.Panel();
         panel2 = new System.Windows.Forms.Panel();
         dgvPeople = new System.Windows.Forms.DataGridView();
         btnAddPerson = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
         SuspendLayout();
         // 
         // panel1
         // 
         panel1.Location = new System.Drawing.Point(12, 12);
         panel1.Name = "panel1";
         panel1.Size = new System.Drawing.Size(200, 100);
         panel1.TabIndex = 0;
         // 
         // panel2
         // 
         panel2.Location = new System.Drawing.Point(218, 12);
         panel2.Name = "panel2";
         panel2.Size = new System.Drawing.Size(200, 100);
         panel2.TabIndex = 1;
         // 
         // dgvPeople
         // 
         dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvPeople.Location = new System.Drawing.Point(12, 118);
         dgvPeople.Name = "dgvPeople";
         dgvPeople.RowTemplate.Height = 25;
         dgvPeople.Size = new System.Drawing.Size(200, 150);
         dgvPeople.TabIndex = 2;
         // 
         // btnAddPerson
         // 
         btnAddPerson.Location = new System.Drawing.Point(244, 345);
         btnAddPerson.Name = "btnAddPerson";
         btnAddPerson.Size = new System.Drawing.Size(75, 23);
         btnAddPerson.TabIndex = 3;
         btnAddPerson.Text = "button1";
         btnAddPerson.UseVisualStyleBackColor = true;
         // 
         // FormFour
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(768, 471);
         Controls.Add(btnAddPerson);
         Controls.Add(dgvPeople);
         Controls.Add(panel2);
         Controls.Add(panel1);
         Name = "FormFour";
         Text = "Система обмена данными с консолью";
         ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.DataGridView dgvPeople;
      private System.Windows.Forms.Button btnAddPerson;
   }
}