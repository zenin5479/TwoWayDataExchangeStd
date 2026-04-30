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

      // Вычисляет факториал и выводит промежуточные шаги в консоль
      private long FactorialWithConsole(int n)
      {
         if (n == 0 || n == 1)
         {
            Console.WriteLine(@"Факториал {0}! = 1", n);
            return 1;
         }

         long fact = 1;
         Console.WriteLine(@"Вычисляем {0}! :", n);
         int i = 2;
         while (i <= n)
         {
            fact *= i;
            Console.WriteLine(@"Шаг {0}: умножаем на {1} -> текущий результат = {2}", i - 1, i, fact);
            i++;
         }

         Console.WriteLine(@"Результат: {0}! = {1}", n, fact);
         return fact;
      }

      private void FormOne_FormClosing(object sender, FormClosingEventArgs e)
      {
         // Освобождаем консоль при закрытии формы
         FreeConsole();
      }
   }
}