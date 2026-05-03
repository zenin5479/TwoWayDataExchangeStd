namespace WinFormsAppThree
{
   partial class FormThree
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
         btnShowSelected = new System.Windows.Forms.Button();
         listBoxPeople = new System.Windows.Forms.ListBox();
         btnStartConsole = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // btnShowSelected
         // 
         btnShowSelected.Location = new System.Drawing.Point(12, 141);
         btnShowSelected.Name = "btnShowSelected";
         btnShowSelected.Size = new System.Drawing.Size(75, 23);
         btnShowSelected.TabIndex = 5;
         btnShowSelected.Text = "Показать выбранное";
         btnShowSelected.UseVisualStyleBackColor = true;
         // 
         // listBoxPeople
         // 
         listBoxPeople.FormattingEnabled = true;
         listBoxPeople.ItemHeight = 15;
         listBoxPeople.Location = new System.Drawing.Point(12, 41);
         listBoxPeople.Name = "listBoxPeople";
         listBoxPeople.Size = new System.Drawing.Size(268, 94);
         listBoxPeople.TabIndex = 4;
         // 
         // btnStartConsole
         // 
         btnStartConsole.Location = new System.Drawing.Point(12, 12);
         btnStartConsole.Name = "btnStartConsole";
         btnStartConsole.Size = new System.Drawing.Size(130, 23);
         btnStartConsole.TabIndex = 3;
         btnStartConsole.Text = "Запустить консоль";
         btnStartConsole.UseVisualStyleBackColor = true;
         // 
         // FormThree
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(299, 176);
         Controls.Add(btnShowSelected);
         Controls.Add(listBoxPeople);
         Controls.Add(btnStartConsole);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FormThree";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Обмен данными с консолью";
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.Button btnShowSelected;
      private System.Windows.Forms.ListBox listBoxPeople;
      private System.Windows.Forms.Button btnStartConsole;
   }
}