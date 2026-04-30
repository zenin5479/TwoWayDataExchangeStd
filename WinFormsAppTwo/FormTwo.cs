using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsAppTwo
{
   public partial class FormTwo : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      public FormTwo()
      {
         InitializeComponent();
         FormClosing += FormOne_FormClosing;

         // Подключаем консоль к процессу
         AllocConsole();
         Console.WriteLine(@"Калькулятор факториала");
         Console.WriteLine(@"Введите число в форму и нажмите кнопку");
         Console.WriteLine(@"Здесь будут отображаться шаги вычисления");
      }

      private void ButtonCalculator_Click(object sender, System.EventArgs e)
      {
         if (!int.TryParse(TextBoxNumber.Text, out int n) || n < 0)
         {
            MessageBox.Show(@"Введите неотрицательное целое число.", @"Ошибка");
            return;
         }

         // Вычисление факториала с выводом в консоль
         long result = FactorialWithConsole(n);

         // Отображаем результат в форме
         LabelResult.Text = string.Format(@"Результат: {0}! = {1}", n, result);

         // Освобождаем консоль после завершения расчетов и передачи данных в форму
         //FreeConsole();
      }
   }
}