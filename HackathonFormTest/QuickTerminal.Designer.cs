namespace HackathonFormTest
{
    partial class QuickTerminal
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
            this.onlineStatusButton = new System.Windows.Forms.Button();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.issuePanel = new System.Windows.Forms.Panel();
            this.issueLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rejectButton = new System.Windows.Forms.Button();
            this.postponeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.issuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlineStatusButton
            // 
            this.onlineStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineStatusButton.Location = new System.Drawing.Point(12, 12);
            this.onlineStatusButton.Name = "onlineStatusButton";
            this.onlineStatusButton.Size = new System.Drawing.Size(173, 37);
            this.onlineStatusButton.TabIndex = 0;
            this.onlineStatusButton.Text = "Go Online!";
            this.onlineStatusButton.UseVisualStyleBackColor = true;
            this.onlineStatusButton.Click += new System.EventHandler(this.onlineStatusButton_Click);
            // 
            // onlineLabel
            // 
            this.onlineLabel.AutoSize = true;
            this.onlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineLabel.Location = new System.Drawing.Point(191, 12);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(241, 37);
            this.onlineLabel.TabIndex = 1;
            this.onlineLabel.Text = "status unknown";
            // 
            // issuePanel
            // 
            this.issuePanel.Controls.Add(this.issueLabel);
            this.issuePanel.Controls.Add(this.rejectButton);
            this.issuePanel.Controls.Add(this.postponeButton);
            this.issuePanel.Controls.Add(this.acceptButton);
            this.issuePanel.Location = new System.Drawing.Point(12, 55);
            this.issuePanel.Name = "issuePanel";
            this.issuePanel.Size = new System.Drawing.Size(1112, 251);
            this.issuePanel.TabIndex = 2;
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLabel.Location = new System.Drawing.Point(3, 0);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(182, 31);
            this.issueLabel.TabIndex = 3;
            this.issueLabel.Text = "<issue detail>";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.Red;
            this.rejectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectButton.Location = new System.Drawing.Point(9, 34);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(173, 37);
            this.rejectButton.TabIndex = 0;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = false;
            // 
            // postponeButton
            // 
            this.postponeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.postponeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postponeButton.Location = new System.Drawing.Point(188, 34);
            this.postponeButton.Name = "postponeButton";
            this.postponeButton.Size = new System.Drawing.Size(173, 37);
            this.postponeButton.TabIndex = 0;
            this.postponeButton.Text = "Postpone";
            this.postponeButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(367, 34);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(173, 37);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // QuickTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 353);
            this.Controls.Add(this.issuePanel);
            this.Controls.Add(this.onlineLabel);
            this.Controls.Add(this.onlineStatusButton);
            this.Name = "QuickTerminal";
            this.Text = "QuickTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickTerminal_FormClosing);
            this.issuePanel.ResumeLayout(false);
            this.issuePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onlineStatusButton;
        private System.Windows.Forms.Label onlineLabel;
        private System.Windows.Forms.Panel issuePanel;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button postponeButton;
        private System.Windows.Forms.Button acceptButton;
    }
}