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
         TextBoxNumbers = new System.Windows.Forms.TextBox();
         ComboBoxOperation = new System.Windows.Forms.ComboBox();
         LabelResult = new System.Windows.Forms.Label();
         lblError = new System.Windows.Forms.Label();
         LabelNumbers = new System.Windows.Forms.Label();
         LabelActions = new System.Windows.Forms.Label();
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
         // TextBoxNumbers
         // 
         TextBoxNumbers.Location = new System.Drawing.Point(12, 12);
         TextBoxNumbers.Name = "TextBoxNumbers";
         TextBoxNumbers.Size = new System.Drawing.Size(100, 23);
         TextBoxNumbers.TabIndex = 1;
         // 
         // ComboBoxOperation
         // 
         ComboBoxOperation.FormattingEnabled = true;
         ComboBoxOperation.Items.AddRange(new object[] { "Sum", "Multiply", "Average" });
         ComboBoxOperation.Location = new System.Drawing.Point(12, 41);
         ComboBoxOperation.Name = "ComboBoxOperation";
         ComboBoxOperation.Size = new System.Drawing.Size(121, 23);
         ComboBoxOperation.TabIndex = 2;
         // 
         // LabelResult
         // 
         LabelResult.AutoSize = true;
         LabelResult.Location = new System.Drawing.Point(12, 82);
         LabelResult.Name = "LabelResult";
         LabelResult.Size = new System.Drawing.Size(66, 15);
         LabelResult.TabIndex = 3;
         LabelResult.Text = "Результат: ";
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
         // LabelActions
         // 
         LabelActions.AutoSize = true;
         LabelActions.Location = new System.Drawing.Point(421, 146);
         LabelActions.Name = "LabelActions";
         LabelActions.Size = new System.Drawing.Size(58, 15);
         LabelActions.TabIndex = 6;
         LabelActions.Text = "Действия";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(596, 241);
         Controls.Add(LabelActions);
         Controls.Add(LabelNumbers);
         Controls.Add(lblError);
         Controls.Add(LabelResult);
         Controls.Add(ComboBoxOperation);
         Controls.Add(TextBoxNumbers);
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
      private System.Windows.Forms.TextBox TextBoxNumbers;
      private System.Windows.Forms.ComboBox ComboBoxOperation;
      private System.Windows.Forms.Label LabelResult;
      private System.Windows.Forms.Label lblError;
      private System.Windows.Forms.Label LabelNumbers;
      private System.Windows.Forms.Label LabelActions;
   }
}