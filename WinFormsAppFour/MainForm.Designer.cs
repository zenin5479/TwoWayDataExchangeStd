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
         ButtonCalculate = new System.Windows.Forms.Button();
         txtNumbers = new System.Windows.Forms.TextBox();
         cmbOperation = new System.Windows.Forms.ComboBox();
         SuspendLayout();
         // 
         // ButtonCalculate
         // 
         ButtonCalculate.Location = new System.Drawing.Point(12, 12);
         ButtonCalculate.Name = "ButtonCalculate";
         ButtonCalculate.Size = new System.Drawing.Size(139, 48);
         ButtonCalculate.TabIndex = 0;
         ButtonCalculate.Text = "Calculate";
         ButtonCalculate.UseVisualStyleBackColor = true;
         ButtonCalculate.Click += button1_Click;
         // 
         // txtNumbers
         // 
         txtNumbers.Location = new System.Drawing.Point(84, 113);
         txtNumbers.Name = "txtNumbers";
         txtNumbers.Size = new System.Drawing.Size(100, 23);
         txtNumbers.TabIndex = 1;
         // 
         // cmbOperation
         // 
         cmbOperation.FormattingEnabled = true;
         cmbOperation.Location = new System.Drawing.Point(305, 47);
         cmbOperation.Name = "cmbOperation";
         cmbOperation.Size = new System.Drawing.Size(121, 23);
         cmbOperation.TabIndex = 2;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(596, 241);
         Controls.Add(cmbOperation);
         Controls.Add(txtNumbers);
         Controls.Add(ButtonCalculate);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Система обмена данными с библиотекой классов";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonCalculate;
      private System.Windows.Forms.TextBox txtNumbers;
      private System.Windows.Forms.ComboBox cmbOperation;
   }
}