using System.Windows.Forms;
using ClassLibraryFour;

namespace WinFormsAppFour
{
   public partial class PersonInputDialog : Form
   {
      public Person CreatedPerson { get; private set; }
      private Person _editPerson;

      public PersonInputDialog(Person editPerson = null)
      {
         InitializeComponent();

         _editPerson = editPerson;


      }
   }
}