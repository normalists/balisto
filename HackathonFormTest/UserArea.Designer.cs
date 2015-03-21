namespace HackathonFormTest
{
    partial class UserArea
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersOnlineLabel = new System.Windows.Forms.Label();
            this.usersOnlineNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersRequiredNumeric = new System.Windows.Forms.NumericUpDown();
            this.showArbiterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersRequiredNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(13, 13);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(120, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "New User Terminal";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersOnlineLabel
            // 
            this.usersOnlineLabel.AutoSize = true;
            this.usersOnlineLabel.Location = new System.Drawing.Point(12, 48);
            this.usersOnlineLabel.Name = "usersOnlineLabel";
            this.usersOnlineLabel.Size = new System.Drawing.Size(70, 13);
            this.usersOnlineLabel.TabIndex = 1;
            this.usersOnlineLabel.Text = "Users Online:";
            // 
            // usersOnlineNumber
            // 
            this.usersOnlineNumber.AutoSize = true;
            this.usersOnlineNumber.Location = new System.Drawing.Point(88, 48);
            this.usersOnlineNumber.Name = "usersOnlineNumber";
            this.usersOnlineNumber.Size = new System.Drawing.Size(63, 13);
            this.usersOnlineNumber.TabIndex = 1;
            this.usersOnlineNumber.Text = "<unknown>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users Required:";
            // 
            // usersRequiredNumeric
            // 
            this.usersRequiredNumeric.Location = new System.Drawing.Point(246, 46);
            this.usersRequiredNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.usersRequiredNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.usersRequiredNumeric.Name = "usersRequiredNumeric";
            this.usersRequiredNumeric.Size = new System.Drawing.Size(54, 20);
            this.usersRequiredNumeric.TabIndex = 3;
            this.usersRequiredNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // showArbiterButton
            // 
            this.showArbiterButton.Location = new System.Drawing.Point(139, 12);
            this.showArbiterButton.Name = "showArbiterButton";
            this.showArbiterButton.Size = new System.Drawing.Size(120, 23);
            this.showArbiterButton.TabIndex = 0;
            this.showArbiterButton.Text = "Show Arbiter Terminal";
            this.showArbiterButton.UseVisualStyleBackColor = true;
            this.showArbiterButton.Click += new System.EventHandler(this.showArbiterButton_Click);
            // 
            // UserArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 102);
            this.Controls.Add(this.usersRequiredNumeric);
            this.Controls.Add(this.usersOnlineNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersOnlineLabel);
            this.Controls.Add(this.showArbiterButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "UserArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserArea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserArea_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.usersRequiredNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label usersOnlineLabel;
        private System.Windows.Forms.Label usersOnlineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown usersRequiredNumeric;
        private System.Windows.Forms.Button showArbiterButton;
    }
}