
namespace AccessibilityDemo_WinFormsNETCore
{
    partial class FormAccQuiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccQuiz));
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.labelAnimalType = new System.Windows.Forms.Label();
            this.comboBoxAnimalType = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelAnimalNameHelp = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(20, 18);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(357, 30);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Try to find 10 problems with this app!";
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.Location = new System.Drawing.Point(20, 111);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(145, 30);
            this.labelAnimalName.TabIndex = 2;
            this.labelAnimalName.Text = "Animal &Name:";
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(166, 108);
            this.textBoxAnimalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(132, 35);
            this.textBoxAnimalName.TabIndex = 2;
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(20, 259);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(132, 30);
            this.labelAnimalType.TabIndex = 4;
            this.labelAnimalType.Text = "Animal &Type:";
            // 
            // comboBoxAnimalType
            // 
            this.comboBoxAnimalType.FormattingEnabled = true;
            this.comboBoxAnimalType.Items.AddRange(new object[] {
            "Birds",
            "Dogs",
            "Fish"});
            this.comboBoxAnimalType.Location = new System.Drawing.Point(166, 252);
            this.comboBoxAnimalType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAnimalType.Name = "comboBoxAnimalType";
            this.comboBoxAnimalType.Size = new System.Drawing.Size(132, 38);
            this.comboBoxAnimalType.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(713, 446);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(117, 49);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelAnimalNameHelp
            // 
            this.labelAnimalNameHelp.AutoSize = true;
            this.labelAnimalNameHelp.Location = new System.Drawing.Point(164, 149);
            this.labelAnimalNameHelp.Name = "labelAnimalNameHelp";
            this.labelAnimalNameHelp.Size = new System.Drawing.Size(296, 30);
            this.labelAnimalNameHelp.TabIndex = 3;
            this.labelAnimalNameHelp.Text = "No spaces in the name please.";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(22, 360);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(136, 51);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "&Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(29, 426);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 30);
            this.labelError.TabIndex = 7;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.AccessibleName = "Herbi logo";
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(689, 16);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 228);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormAccQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 510);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelAnimalName);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.labelAnimalNameHelp);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.comboBoxAnimalType);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAccQuiz";
            this.Text = "New Year\'s Accessibility Quiz!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelAnimalName;
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.Label labelAnimalType;
        private System.Windows.Forms.ComboBox comboBoxAnimalType;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelAnimalNameHelp;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

