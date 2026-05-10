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
         SuspendLayout();
         // 
         // dtpBirth
         // 
         dtpBirth.Location = new System.Drawing.Point(12, 12);
         dtpBirth.Name = "dtpBirth";
         dtpBirth.Size = new System.Drawing.Size(200, 23);
         dtpBirth.TabIndex = 0;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(57, 89);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(38, 15);
         label1.TabIndex = 1;
         label1.Text = "label1";
         // 
         // PersonInputDialog
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(372, 232);
         Controls.Add(label1);
         Controls.Add(dtpBirth);
         Name = "PersonInputDialog";
         Text = "Редактирование человека";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.DateTimePicker dtpBirth;
      private System.Windows.Forms.Label label1;
   }
}