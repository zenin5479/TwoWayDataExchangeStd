using SharedStorageFour;
using System;
using System.Windows.Forms;

namespace WinFormsAppFour
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         cmbOperation.SelectedIndex = 0;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         lblResult.Text = "";
         lblError.Text = "";

         string[] parts = txtNumbers.Text.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
         double[] numbers;
         try
         {
            numbers = Array.ConvertAll(parts, double.Parse);
         }
         catch
         {
            lblError.Text = "Ошибка: введите числа через пробел или запятую";
            return;
         }

         var request = new CalculationRequest
         {
            Numbers = numbers,
            Operation = cmbOperation.SelectedItem.ToString()
         };

         try
         {
            using (var storage = new StreamSharedStorage("ConsoleAppFour.exe"))
            {
               CalculationResponse response = storage.SendRequest(request);

               if (!string.IsNullOrEmpty(response.Error))
                  lblError.Text = "Ошибка: " + response.Error;
               else
                  lblResult.Text = "Результат: " + response.Result;
            }
         }
         catch (Exception ex)
         {
            lblError.Text = "Ошибка запуска/обмена: " + ex.Message;
         }
      }
   }
}