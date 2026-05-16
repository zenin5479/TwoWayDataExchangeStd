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
         btnCalculate = new System.Windows.Forms.Button();
         txtNumbers = new System.Windows.Forms.TextBox();
         cmbOperation = new System.Windows.Forms.ComboBox();
         lblResult = new System.Windows.Forms.Label();
         lblError = new System.Windows.Forms.Label();
         LabelNumbers = new System.Windows.Forms.Label();
         label2 = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // btnCalculate
         // 
         btnCalculate.Location = new System.Drawing.Point(12, 115);
         btnCalculate.Name = "btnCalculate";
         btnCalculate.Size = new System.Drawing.Size(139, 48);
         btnCalculate.TabIndex = 0;
         btnCalculate.Text = "Вычислить";
         btnCalculate.UseVisualStyleBackColor = true;
         btnCalculate.Click += button1_Click;
         // 
         // txtNumbers
         // 
         txtNumbers.Location = new System.Drawing.Point(12, 12);
         txtNumbers.Name = "txtNumbers";
         txtNumbers.Size = new System.Drawing.Size(100, 23);
         txtNumbers.TabIndex = 1;
         // 
         // cmbOperation
         // 
         cmbOperation.FormattingEnabled = true;
         cmbOperation.Items.AddRange(new object[] { "Sum", "Multiply", "Average" });
         cmbOperation.Location = new System.Drawing.Point(12, 41);
         cmbOperation.Name = "cmbOperation";
         cmbOperation.Size = new System.Drawing.Size(121, 23);
         cmbOperation.TabIndex = 2;
         // 
         // lblResult
         // 
         lblResult.AutoSize = true;
         lblResult.Location = new System.Drawing.Point(12, 82);
         lblResult.Name = "lblResult";
         lblResult.Size = new System.Drawing.Size(66, 15);
         lblResult.TabIndex = 3;
         lblResult.Text = "Результат: ";
         // 
         // lblError
         // 
         lblError.AutoSize = true;
         lblError.Location = new System.Drawing.Point(12, 97);
         lblError.Name = "lblError";
         lblError.Size = new System.Drawing.Size(59, 15);
         lblError.TabIndex = 4;
         lblError.Text = "Ошибка: ";
         // 
         // LabelNumbers
         // 
         LabelNumbers.AutoSize = true;
         LabelNumbers.Location = new System.Drawing.Point(442, 94);
         LabelNumbers.Name = "LabelNumbers";
         LabelNumbers.Size = new System.Drawing.Size(41, 15);
         LabelNumbers.TabIndex = 5;
         LabelNumbers.Text = "Числа";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new System.Drawing.Point(421, 146);
         label2.Name = "label2";
         label2.Size = new System.Drawing.Size(58, 15);
         label2.TabIndex = 6;
         label2.Text = "Действия";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(596, 241);
         Controls.Add(label2);
         Controls.Add(LabelNumbers);
         Controls.Add(lblError);
         Controls.Add(lblResult);
         Controls.Add(cmbOperation);
         Controls.Add(txtNumbers);
         Controls.Add(btnCalculate);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Система обмена данными с библиотекой классов";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.TextBox txtNumbers;
      private System.Windows.Forms.ComboBox cmbOperation;
      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.Label lblError;
      private System.Windows.Forms.Label LabelNumbers;
      private System.Windows.Forms.Label label2;
   }
}