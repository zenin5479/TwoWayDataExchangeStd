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
      }

      private void ButtonCalculator_Click(object sender, System.EventArgs e)
      {

      }
   }
}