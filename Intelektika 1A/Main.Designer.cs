namespace Intelektika_1A
{
    partial class Main
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.neibCombo = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notSportView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sportView = new System.Windows.Forms.ListView();
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.sportText = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 159);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(84, 13);
            this.timeLabel.TabIndex = 22;
            this.timeLabel.Text = "Calculation time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Player";
            // 
            // pointCombo
            // 
            this.pointCombo.FormattingEnabled = true;
            this.pointCombo.Location = new System.Drawing.Point(12, 77);
            this.pointCombo.Name = "pointCombo";
            this.pointCombo.Size = new System.Drawing.Size(121, 21);
            this.pointCombo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Neighbour number:";
            // 
            // neibCombo
            // 
            this.neibCombo.FormattingEnabled = true;
            this.neibCombo.Location = new System.Drawing.Point(12, 135);
            this.neibCombo.Name = "neibCombo";
            this.neibCombo.Size = new System.Drawing.Size(121, 21);
            this.neibCombo.TabIndex = 18;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(34, 178);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 17;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sport";
            // 
            // notSportView
            // 
            this.notSportView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.notSportView.HideSelection = false;
            this.notSportView.Location = new System.Drawing.Point(433, 28);
            this.notSportView.Name = "notSportView";
            this.notSportView.Size = new System.Drawing.Size(163, 139);
            this.notSportView.TabIndex = 24;
            this.notSportView.UseCompatibleStateImageBehavior = false;
            this.notSportView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Height";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Weight";
            // 
            // sportView
            // 
            this.sportView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Height,
            this.Weight,
            this.Sport,
            this.Position});
            this.sportView.HideSelection = false;
            this.sportView.Location = new System.Drawing.Point(150, 28);
            this.sportView.Name = "sportView";
            this.sportView.Size = new System.Drawing.Size(251, 139);
            this.sportView.TabIndex = 23;
            this.sportView.UseCompatibleStateImageBehavior = false;
            this.sportView.View = System.Windows.Forms.View.Details;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 59;
            // 
            // Sport
            // 
            this.Sport.Text = "Sport";
            // 
            // Position
            // 
            this.Position.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sport";
            // 
            // sportText
            // 
            this.sportText.FormattingEnabled = true;
            this.sportText.Items.AddRange(new object[] {
            "----------",
            "Football",
            "Basketball"});
            this.sportText.Location = new System.Drawing.Point(12, 28);
            this.sportText.Name = "sportText";
            this.sportText.Size = new System.Drawing.Size(121, 21);
            this.sportText.TabIndex = 28;
            this.sportText.SelectedIndexChanged += new System.EventHandler(this.sportText_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sportText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notSportView);
            this.Controls.Add(this.sportView);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pointCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neibCombo);
            this.Controls.Add(this.Calculate);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox neibCombo;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView notSportView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView sportView;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Sport;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sportText;
    }
}

