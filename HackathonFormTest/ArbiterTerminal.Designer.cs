namespace HackathonFormTest
{
    partial class ArbiterTerminal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.issuePanel = new System.Windows.Forms.Panel();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.historyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.issueLabel = new System.Windows.Forms.Label();
            this.rejectButton = new System.Windows.Forms.Button();
            this.postponeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.onlineStatusButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newsFeed = new System.Windows.Forms.ListBox();
            this.fromDP = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toDP = new System.Windows.Forms.DateTimePicker();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.issuePanel.SuspendLayout();
            this.graphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // issuePanel
            // 
            this.issuePanel.Controls.Add(this.searchLabel);
            this.issuePanel.Controls.Add(this.searchTextBox);
            this.issuePanel.Controls.Add(this.searchButton);
            this.issuePanel.Controls.Add(this.toLabel);
            this.issuePanel.Controls.Add(this.fromLabel);
            this.issuePanel.Controls.Add(this.toDP);
            this.issuePanel.Controls.Add(this.fromDP);
            this.issuePanel.Controls.Add(this.newsFeed);
            this.issuePanel.Controls.Add(this.graphPanel);
            this.issuePanel.Controls.Add(this.issueLabel);
            this.issuePanel.Controls.Add(this.rejectButton);
            this.issuePanel.Controls.Add(this.postponeButton);
            this.issuePanel.Controls.Add(this.acceptButton);
            this.issuePanel.Location = new System.Drawing.Point(12, 55);
            this.issuePanel.Name = "issuePanel";
            this.issuePanel.Size = new System.Drawing.Size(1112, 419);
            this.issuePanel.TabIndex = 5;
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.historyChart);
            this.graphPanel.Location = new System.Drawing.Point(9, 78);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(531, 170);
            this.graphPanel.TabIndex = 4;
            // 
            // historyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.historyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.historyChart.Legends.Add(legend1);
            this.historyChart.Location = new System.Drawing.Point(3, 3);
            this.historyChart.Name = "historyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.historyChart.Series.Add(series1);
            this.historyChart.Size = new System.Drawing.Size(525, 164);
            this.historyChart.TabIndex = 0;
            this.historyChart.Text = "chart1";
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
            // onlineLabel
            // 
            this.onlineLabel.AutoSize = true;
            this.onlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineLabel.Location = new System.Drawing.Point(191, 12);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(241, 37);
            this.onlineLabel.TabIndex = 4;
            this.onlineLabel.Text = "status unknown";
            // 
            // onlineStatusButton
            // 
            this.onlineStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineStatusButton.Location = new System.Drawing.Point(12, 12);
            this.onlineStatusButton.Name = "onlineStatusButton";
            this.onlineStatusButton.Size = new System.Drawing.Size(173, 37);
            this.onlineStatusButton.TabIndex = 3;
            this.onlineStatusButton.Text = "Go Online!";
            this.onlineStatusButton.UseVisualStyleBackColor = true;
            this.onlineStatusButton.Click += new System.EventHandler(this.onlineStatusButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newsFeed
            // 
            this.newsFeed.FormattingEnabled = true;
            this.newsFeed.Location = new System.Drawing.Point(9, 319);
            this.newsFeed.Name = "newsFeed";
            this.newsFeed.Size = new System.Drawing.Size(531, 95);
            this.newsFeed.TabIndex = 5;
            // 
            // fromDP
            // 
            this.fromDP.CustomFormat = "dd MM yyyy HH:mm:ss";
            this.fromDP.Location = new System.Drawing.Point(9, 293);
            this.fromDP.Name = "fromDP";
            this.fromDP.Size = new System.Drawing.Size(200, 20);
            this.fromDP.TabIndex = 6;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(9, 277);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(217, 277);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "To:";
            // 
            // toDP
            // 
            this.toDP.CustomFormat = "dd MM yyyy HH:mm:ss";
            this.toDP.Location = new System.Drawing.Point(220, 293);
            this.toDP.Name = "toDP";
            this.toDP.Size = new System.Drawing.Size(200, 20);
            this.toDP.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(77, 258);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(208, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 261);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 13);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search for:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(291, 251);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(173, 37);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ArbiterTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 486);
            this.Controls.Add(this.issuePanel);
            this.Controls.Add(this.onlineLabel);
            this.Controls.Add(this.onlineStatusButton);
            this.Name = "ArbiterTerminal";
            this.Text = "ArbiterTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArbiterTerminal_FormClosing);
            this.issuePanel.ResumeLayout(false);
            this.issuePanel.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel issuePanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart historyChart;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button postponeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label onlineLabel;
        private System.Windows.Forms.Button onlineStatusButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker toDP;
        private System.Windows.Forms.DateTimePicker fromDP;
        private System.Windows.Forms.ListBox newsFeed;
    }
}