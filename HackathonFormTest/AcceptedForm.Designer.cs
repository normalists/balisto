namespace HackathonFormTest
{
    partial class AcceptedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acceptedListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // acceptedListBox
            // 
            this.acceptedListBox.FormattingEnabled = true;
            this.acceptedListBox.Location = new System.Drawing.Point(12, 12);
            this.acceptedListBox.Name = "acceptedListBox";
            this.acceptedListBox.Size = new System.Drawing.Size(250, 134);
            this.acceptedListBox.TabIndex = 0;
            // 
            // AcceptedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.acceptedListBox);
            this.Location = new System.Drawing.Point(100, 350);
            this.Name = "AcceptedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AcceptedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcceptedForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox acceptedListBox;
    }
}