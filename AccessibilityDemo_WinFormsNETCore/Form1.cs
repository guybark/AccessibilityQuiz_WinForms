using System;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace AccessibilityDemo_WinFormsNETCore
{
    public partial class FormAccQuiz : Form
    {
        public FormAccQuiz()
        {
            InitializeComponent();

            // Make sure screen readers are notified of changes to the error text.
            labelError.LiveSetting = AutomationLiveSetting.Assertive;

            // Associate the TextBox with the visually-nearby helpful text.
            textBoxAnimalName.QueryAccessibilityHelp += AnimalNameTextBox_QueryAccessibilityHelp;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelError.Text = "Sorry, nothing is available to show at the moment.";
        }

        private void AnimalNameTextBox_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
            e.HelpString = labelAnimalNameHelp.Text;
        }
    }
}
