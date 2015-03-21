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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.onlineStatusButton = new System.Windows.Forms.Button();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.issuePanel = new System.Windows.Forms.Panel();
            this.issueLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rejectButton = new System.Windows.Forms.Button();
            this.postponeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.attributePanel = new System.Windows.Forms.Panel();
            this.historyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.issuePanel.SuspendLayout();
            this.graphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyChart)).BeginInit();
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
            this.issuePanel.Controls.Add(this.attributePanel);
            this.issuePanel.Controls.Add(this.graphPanel);
            this.issuePanel.Controls.Add(this.issueLabel);
            this.issuePanel.Controls.Add(this.rejectButton);
            this.issuePanel.Controls.Add(this.postponeButton);
            this.issuePanel.Controls.Add(this.acceptButton);
            this.issuePanel.Location = new System.Drawing.Point(12, 55);
            this.issuePanel.Name = "issuePanel";
            this.issuePanel.Size = new System.Drawing.Size(1112, 261);
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
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
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
            this.postponeButton.Click += new System.EventHandler(this.postponeButton_Click);
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
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.historyChart);
            this.graphPanel.Location = new System.Drawing.Point(9, 78);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(531, 170);
            this.graphPanel.TabIndex = 4;
            // 
            // attributePanel
            // 
            this.attributePanel.Location = new System.Drawing.Point(547, 78);
            this.attributePanel.Name = "attributePanel";
            this.attributePanel.Size = new System.Drawing.Size(354, 170);
            this.attributePanel.TabIndex = 5;
            // 
            // historyChart
            // 
            chartArea4.Name = "ChartArea1";
            this.historyChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.historyChart.Legends.Add(legend4);
            this.historyChart.Location = new System.Drawing.Point(3, 3);
            this.historyChart.Name = "historyChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.historyChart.Series.Add(series4);
            this.historyChart.Size = new System.Drawing.Size(525, 164);
            this.historyChart.TabIndex = 0;
            this.historyChart.Text = "chart1";
            // 
            // QuickTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 330);
            this.Controls.Add(this.issuePanel);
            this.Controls.Add(this.onlineLabel);
            this.Controls.Add(this.onlineStatusButton);
            this.Name = "QuickTerminal";
            this.Text = "QuickTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickTerminal_FormClosing);
            this.issuePanel.ResumeLayout(false);
            this.issuePanel.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyChart)).EndInit();
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
        private System.Windows.Forms.Panel attributePanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart historyChart;
    }
}