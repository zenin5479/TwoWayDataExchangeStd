using System.Windows.Forms;

namespace WinFormsAppThree
{
   public partial class FormThree : Form
   {
      private DataStorage _storage;
      private ConsoleAppThree _consoleAppThree;

      public FormThree()
      {
         InitializeComponent();

         _storage = new DataStorage();
         _storage = new DataStorage();
         _consoleAppThree = new ConsoleAppThree(_storage);


      }

      private void btnStartConsole_Click(object sender, System.EventArgs e)
      {

      }

      private void btnShowSelected_Click(object sender, System.EventArgs e)
      {

      }
   }
}