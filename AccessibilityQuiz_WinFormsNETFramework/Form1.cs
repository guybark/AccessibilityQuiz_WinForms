using System;
using System.Windows.Forms;

namespace AccessibilityDemo_WinFormsNETFramework
{
    public partial class FormAccQuiz : Form
    {
        public FormAccQuiz()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelError.Text = "Sorry, nothing is available to show at the moment.";
        }
    }
}
