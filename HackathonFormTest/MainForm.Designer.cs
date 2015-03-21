namespace HackathonFormTest
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.toggleFeedDisplay = new System.Windows.Forms.Button();
            this.feedTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.toggleAcceptedDisplay = new System.Windows.Forms.Button();
            this.questionableDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggleFeedDisplay
            // 
            this.toggleFeedDisplay.Location = new System.Drawing.Point(12, 55);
            this.toggleFeedDisplay.Name = "toggleFeedDisplay";
            this.toggleFeedDisplay.Size = new System.Drawing.Size(130, 23);
            this.toggleFeedDisplay.TabIndex = 0;
            this.toggleFeedDisplay.Text = "Feed Display";
            this.toggleFeedDisplay.UseVisualStyleBackColor = true;
            this.toggleFeedDisplay.Click += new System.EventHandler(this.toggleFeedDisplay_Click);
            // 
            // feedTimer
            // 
            this.feedTimer.Interval = 10;
            this.feedTimer.Tick += new System.EventHandler(this.feedTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(130, 37);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "<TIME>";
            // 
            // toggleAcceptedDisplay
            // 
            this.toggleAcceptedDisplay.Location = new System.Drawing.Point(12, 84);
            this.toggleAcceptedDisplay.Name = "toggleAcceptedDisplay";
            this.toggleAcceptedDisplay.Size = new System.Drawing.Size(130, 23);
            this.toggleAcceptedDisplay.TabIndex = 0;
            this.toggleAcceptedDisplay.Text = "Accepted Display";
            this.toggleAcceptedDisplay.UseVisualStyleBackColor = true;
            this.toggleAcceptedDisplay.Click += new System.EventHandler(this.toggleAcceptedDisplay_Click);
            // 
            // questionableDisplay
            // 
            this.questionableDisplay.Location = new System.Drawing.Point(12, 113);
            this.questionableDisplay.Name = "questionableDisplay";
            this.questionableDisplay.Size = new System.Drawing.Size(130, 23);
            this.questionableDisplay.TabIndex = 2;
            this.questionableDisplay.Text = "Questionable Display";
            this.questionableDisplay.UseVisualStyleBackColor = true;
            this.questionableDisplay.Click += new System.EventHandler(this.questionableDisplay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 162);
            this.Controls.Add(this.questionableDisplay);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.toggleAcceptedDisplay);
            this.Controls.Add(this.toggleFeedDisplay);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Centre";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleFeedDisplay;
        private System.Windows.Forms.Timer feedTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button toggleAcceptedDisplay;
        private System.Windows.Forms.Button questionableDisplay;
    }
}

