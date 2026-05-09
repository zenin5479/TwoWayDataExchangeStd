using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppFour
{
   public partial class FormFour : Form
   {
      public FormFour()
      {
         InitializeComponent();
         RefreshDataGrid();
         UpdateStatus();
      }

      private void btnAddPerson_Click(object sender, System.EventArgs e)
      {
         using (var inputDialog = new PersonInputDialog())
         {
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
               GlobalStorage.AddPerson(inputDialog.CreatedPerson);
               RefreshDataGrid();
               UpdateStatus();
               MessageBox.Show($"Человек {inputDialog.CreatedPerson.Name} добавлен!", "Успех",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private void btnRunConsole_Click(object sender, System.EventArgs e)
      {
         // Находим путь к консольному EXE
         string consolePath = System.IO.Path.Combine(
            System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            "..", "..", "..", "ConsoleWorker", "bin", "Debug", "netcoreapp3.1", "ConsoleWorker.exe");

         if (!System.IO.File.Exists(consolePath))
         {
            MessageBox.Show($"Не найден ConsoleWorker.exe по пути:\n{consolePath}\n\nУкажите правильный путь!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // Запускаем консольное приложение синхронно
         this.Cursor = Cursors.WaitCursor;
         try
         {
            var process = new Process
            {
               StartInfo = new ProcessStartInfo
               {
                  FileName = consolePath,
                  UseShellExecute = false,
                  CreateNoWindow = true, // Без окна консоли
                  WindowStyle = ProcessWindowStyle.Hidden
               }
            };

            process.Start();
            process.WaitForExit();

            // После завершения консоли читаем обновлённые данные
            RefreshDataGrid();
            UpdateStatus();

            // Показываем сообщение от консоли
            if (!string.IsNullOrEmpty(GlobalStorage.LastConsoleOutput))
            {
               lblConsoleMessage.Text = GlobalStorage.LastConsoleOutput;
               MessageBox.Show(GlobalStorage.LastConsoleOutput, "Результат работы консоли",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         finally
         {
            this.Cursor = Cursors.Default;
         }
      }
   }
}