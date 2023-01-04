using System.Windows.Forms;

namespace CinemaManager.Models
{
    internal class DialogMessages
    {
        public static bool ConfirmationMessage(string message)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }
            return false;
        }
        //Error message box
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Warning message
        public static void WarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Information message
        public static void InformationMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Success message
        public static void SuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
