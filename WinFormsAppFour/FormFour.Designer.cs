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
         dataGridView1 = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
         // dataGridView1
         // 
         dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridView1.Location = new System.Drawing.Point(12, 118);
         dataGridView1.Name = "dataGridView1";
         dataGridView1.RowTemplate.Height = 25;
         dataGridView1.Size = new System.Drawing.Size(200, 150);
         dataGridView1.TabIndex = 2;
         // 
         // FormFour
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(768, 471);
         Controls.Add(dataGridView1);
         Controls.Add(panel2);
         Controls.Add(panel1);
         Name = "FormFour";
         Text = "Система обмена данными с консолью";
         ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.DataGridView dataGridView1;
   }
}