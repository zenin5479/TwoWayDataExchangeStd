namespace WinFormsAppTwo
{
   partial class FormTwo
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
         LabelPrompt = new System.Windows.Forms.Label();
         ButtonCalculator = new System.Windows.Forms.Button();
         LabelResult = new System.Windows.Forms.Label();
         TextBoxNumber = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // LabelPrompt
         // 
         LabelPrompt.AutoSize = true;
         LabelPrompt.Location = new System.Drawing.Point(112, 86);
         LabelPrompt.Name = "LabelPrompt";
         LabelPrompt.Size = new System.Drawing.Size(161, 15);
         LabelPrompt.TabIndex = 7;
         LabelPrompt.Text = "Введите целое число (0..20):";
         // 
         // ButtonCalculator
         // 
         ButtonCalculator.Location = new System.Drawing.Point(112, 133);
         ButtonCalculator.Name = "ButtonCalculator";
         ButtonCalculator.Size = new System.Drawing.Size(150, 23);
         ButtonCalculator.TabIndex = 6;
         ButtonCalculator.Text = "Вычислить факториал";
         ButtonCalculator.UseVisualStyleBackColor = true;
         // 
         // LabelResult
         // 
         LabelResult.AutoSize = true;
         LabelResult.Location = new System.Drawing.Point(112, 159);
         LabelResult.Name = "LabelResult";
         LabelResult.Size = new System.Drawing.Size(66, 15);
         LabelResult.TabIndex = 5;
         LabelResult.Text = "Результат: ";
         // 
         // TextBoxNumber
         // 
         TextBoxNumber.Location = new System.Drawing.Point(112, 104);
         TextBoxNumber.Name = "TextBoxNumber";
         TextBoxNumber.Size = new System.Drawing.Size(150, 23);
         TextBoxNumber.TabIndex = 4;
         // 
         // FormTwo
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(LabelPrompt);
         Controls.Add(ButtonCalculator);
         Controls.Add(LabelResult);
         Controls.Add(TextBoxNumber);
         Name = "FormTwo";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Факториал через консоль";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label LabelPrompt;
      private System.Windows.Forms.Button ButtonCalculator;
      private System.Windows.Forms.Label LabelResult;
      private System.Windows.Forms.TextBox TextBoxNumber;
   }
}