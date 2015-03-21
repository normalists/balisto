namespace HackathonFormTest
{
    partial class QuestionableForm
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
            this.questionedListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // questionedListBox
            // 
            this.questionedListBox.FormattingEnabled = true;
            this.questionedListBox.Location = new System.Drawing.Point(12, 12);
            this.questionedListBox.Name = "questionedListBox";
            this.questionedListBox.Size = new System.Drawing.Size(543, 95);
            this.questionedListBox.TabIndex = 0;
            // 
            // QuestionableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 206);
            this.Controls.Add(this.questionedListBox);
            this.Location = new System.Drawing.Point(600, 400);
            this.Name = "QuestionableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuestionableForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionableForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox questionedListBox;
    }
}