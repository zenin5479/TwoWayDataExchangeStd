using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsAppOne
{
   public partial class FormOne : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      public FormOne()
      {
         InitializeComponent();
      }

      private void btnCalculate_Click(object sender, System.EventArgs e)
      {

      }
   }
}