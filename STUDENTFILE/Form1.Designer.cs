namespace STUDENTFILE
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearLevelComboBox = new System.Windows.Forms.ComboBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.IdNumberTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(125, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Entry";
            // 
            // yearLevelComboBox
            // 
            this.yearLevelComboBox.FormattingEnabled = true;
            this.yearLevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.yearLevelComboBox.Location = new System.Drawing.Point(276, 348);
            this.yearLevelComboBox.Name = "yearLevelComboBox";
            this.yearLevelComboBox.Size = new System.Drawing.Size(113, 24);
            this.yearLevelComboBox.TabIndex = 26;
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "Bsit",
            "IS"});
            this.courseComboBox.Location = new System.Drawing.Point(276, 309);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(113, 24);
            this.courseComboBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Year Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Course";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentFirstNameTextBox
            // 
            this.StudentFirstNameTextBox.Location = new System.Drawing.Point(276, 257);
            this.StudentFirstNameTextBox.Name = "StudentFirstNameTextBox";
            this.StudentFirstNameTextBox.Size = new System.Drawing.Size(185, 22);
            this.StudentFirstNameTextBox.TabIndex = 20;
            // 
            // StudentLastNameTextBox
            // 
            this.StudentLastNameTextBox.Location = new System.Drawing.Point(276, 203);
            this.StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            this.StudentLastNameTextBox.Size = new System.Drawing.Size(185, 22);
            this.StudentLastNameTextBox.TabIndex = 19;
            // 
            // IdNumberTextbox
            // 
            this.IdNumberTextbox.Location = new System.Drawing.Point(276, 150);
            this.IdNumberTextbox.Name = "IdNumberTextbox";
            this.IdNumberTextbox.Size = new System.Drawing.Size(185, 22);
            this.IdNumberTextbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "STUDFNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "STUDLNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID No.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yearLevelComboBox);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentFirstNameTextBox);
            this.Controls.Add(this.StudentLastNameTextBox);
            this.Controls.Add(this.IdNumberTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearLevelComboBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StudentFirstNameTextBox;
        private System.Windows.Forms.TextBox StudentLastNameTextBox;
        private System.Windows.Forms.TextBox IdNumberTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

