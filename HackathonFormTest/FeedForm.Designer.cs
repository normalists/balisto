namespace HackathonFormTest
{
    partial class FeedForm
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
            this.feedList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // feedList
            // 
            this.feedList.FormattingEnabled = true;
            this.feedList.Location = new System.Drawing.Point(12, 12);
            this.feedList.Name = "feedList";
            this.feedList.Size = new System.Drawing.Size(258, 108);
            this.feedList.TabIndex = 0;
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 198);
            this.Controls.Add(this.feedList);
            this.Name = "FeedForm";
            this.Text = "FeedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox feedList;
    }
}