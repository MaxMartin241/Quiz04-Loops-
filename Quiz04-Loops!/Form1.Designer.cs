namespace Quiz04_Loops_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            q1OutputLabel = new Label();
            q1Button = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            q2OutputLabel = new Label();
            q2Button = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            q4TextBox = new TextBox();
            q3Button = new Button();
            q4OutputLabel = new Label();
            panel3 = new Panel();
            label12 = new Label();
            panel4 = new Panel();
            q5OutputLabel = new Label();
            q5Button = new Button();
            label13 = new Label();
            q5InstructButton = new Button();
            bonusButton = new Button();
            bonusLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Maroon;
            label1.Location = new Point(394, -2);
            label1.Name = "label1";
            label1.Size = new Size(12, 675);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(386, 32);
            label2.TabIndex = 1;
            label2.Text = "Q01 - Counted Loops (for loop) (3 marks)";
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 41);
            label3.Name = "label3";
            label3.Size = new Size(386, 47);
            label3.TabIndex = 2;
            label3.Text = "Use a for..loop to output  “HO HO HO”  exactly five times in the label below.";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 88);
            label4.Name = "label4";
            label4.Size = new Size(386, 23);
            label4.TabIndex = 3;
            label4.Text = "-------------------------------------------------------------";
            // 
            // q1OutputLabel
            // 
            q1OutputLabel.BackColor = Color.Green;
            q1OutputLabel.ForeColor = Color.White;
            q1OutputLabel.Location = new Point(13, 9);
            q1OutputLabel.Name = "q1OutputLabel";
            q1OutputLabel.Size = new Size(350, 80);
            q1OutputLabel.TabIndex = 4;
            q1OutputLabel.Click += q1OutputLabel_Click;
            // 
            // q1Button
            // 
            q1Button.ForeColor = Color.Maroon;
            q1Button.Location = new Point(64, 114);
            q1Button.Name = "q1Button";
            q1Button.Size = new Size(277, 36);
            q1Button.TabIndex = 5;
            q1Button.Text = "Code Me!";
            q1Button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(q1OutputLabel);
            panel1.Location = new Point(12, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 100);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(q2OutputLabel);
            panel2.Location = new Point(12, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 100);
            panel2.TabIndex = 11;
            // 
            // q2OutputLabel
            // 
            q2OutputLabel.BackColor = Color.Green;
            q2OutputLabel.ForeColor = Color.White;
            q2OutputLabel.Location = new Point(13, 9);
            q2OutputLabel.Name = "q2OutputLabel";
            q2OutputLabel.Size = new Size(350, 80);
            q2OutputLabel.TabIndex = 4;
            // 
            // q2Button
            // 
            q2Button.ForeColor = Color.Maroon;
            q2Button.Location = new Point(64, 374);
            q2Button.Name = "q2Button";
            q2Button.Size = new Size(277, 36);
            q2Button.TabIndex = 10;
            q2Button.Text = "Code Me!";
            q2Button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 348);
            label6.Name = "label6";
            label6.Size = new Size(386, 23);
            label6.TabIndex = 9;
            label6.Text = "-------------------------------------------------------------";
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(2, 301);
            label7.Name = "label7";
            label7.Size = new Size(386, 47);
            label7.TabIndex = 8;
            label7.Text = "Use a while loop to output  “HO HO HO”  exactly five times in the label below.";
            // 
            // label8
            // 
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(2, 269);
            label8.Name = "label8";
            label8.Size = new Size(404, 32);
            label8.TabIndex = 7;
            label8.Text = "Q02 - Counted Loops (while loop) (3 marks)";
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(412, 41);
            label5.Name = "label5";
            label5.Size = new Size(532, 86);
            label5.TabIndex = 13;
            label5.Text = "Use a loop to output “HO HO HO” the exact number of times that the user requests in the textbox.  Be sure to set up your code not to crash if the user does not enter an integer.";
            // 
            // label9
            // 
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(412, 9);
            label9.Name = "label9";
            label9.Size = new Size(532, 32);
            label9.TabIndex = 12;
            label9.Text = "Q04 - User Defined Number of Times (4 marks)";
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(412, 139);
            label10.Name = "label10";
            label10.Size = new Size(177, 28);
            label10.TabIndex = 14;
            label10.Text = "Enter an integer";
            // 
            // label11
            // 
            label11.ForeColor = Color.White;
            label11.Location = new Point(412, 116);
            label11.Name = "label11";
            label11.Size = new Size(532, 23);
            label11.TabIndex = 15;
            label11.Text = "-------------------------------------------------------------";
            // 
            // q4TextBox
            // 
            q4TextBox.Location = new Point(595, 139);
            q4TextBox.Name = "q4TextBox";
            q4TextBox.Size = new Size(100, 26);
            q4TextBox.TabIndex = 16;
            // 
            // q3Button
            // 
            q3Button.ForeColor = Color.Maroon;
            q3Button.Location = new Point(736, 133);
            q3Button.Name = "q3Button";
            q3Button.Size = new Size(170, 36);
            q3Button.TabIndex = 17;
            q3Button.Text = "Code Me!";
            q3Button.UseVisualStyleBackColor = true;
            // 
            // q4OutputLabel
            // 
            q4OutputLabel.BackColor = Color.Green;
            q4OutputLabel.ForeColor = Color.White;
            q4OutputLabel.Location = new Point(13, 10);
            q4OutputLabel.Name = "q4OutputLabel";
            q4OutputLabel.Size = new Size(495, 80);
            q4OutputLabel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(q4OutputLabel);
            panel3.Location = new Point(412, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 100);
            panel3.TabIndex = 12;
            // 
            // label12
            // 
            label12.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(412, 290);
            label12.Name = "label12";
            label12.Size = new Size(532, 32);
            label12.TabIndex = 18;
            label12.Text = "Q05 Nested Loops (2 marks) ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(q5OutputLabel);
            panel4.Location = new Point(412, 374);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 170);
            panel4.TabIndex = 13;
            // 
            // q5OutputLabel
            // 
            q5OutputLabel.BackColor = Color.Green;
            q5OutputLabel.ForeColor = Color.White;
            q5OutputLabel.Location = new Point(13, 14);
            q5OutputLabel.Name = "q5OutputLabel";
            q5OutputLabel.Size = new Size(209, 141);
            q5OutputLabel.TabIndex = 4;
            // 
            // q5Button
            // 
            q5Button.ForeColor = Color.Maroon;
            q5Button.Location = new Point(436, 325);
            q5Button.Name = "q5Button";
            q5Button.Size = new Size(170, 36);
            q5Button.TabIndex = 19;
            q5Button.Text = "Code Me!";
            q5Button.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(666, 405);
            label13.Name = "label13";
            label13.Size = new Size(240, 39);
            label13.TabIndex = 20;
            label13.Text = "Q05 is required for ICS3U and bonus for ICS3C";
            // 
            // q5InstructButton
            // 
            q5InstructButton.ForeColor = Color.Maroon;
            q5InstructButton.Location = new Point(666, 456);
            q5InstructButton.Name = "q5InstructButton";
            q5InstructButton.Size = new Size(294, 49);
            q5InstructButton.TabIndex = 21;
            q5InstructButton.Text = "Click Me for Question 05 Instructions";
            q5InstructButton.UseVisualStyleBackColor = true;
            q5InstructButton.Click += button1_Click;
            // 
            // bonusButton
            // 
            bonusButton.ForeColor = Color.Maroon;
            bonusButton.Location = new Point(12, 522);
            bonusButton.Name = "bonusButton";
            bonusButton.Size = new Size(376, 36);
            bonusButton.TabIndex = 22;
            bonusButton.Text = "Bonus Question +1";
            bonusButton.UseVisualStyleBackColor = true;
            bonusButton.Click += bonusButton_Click;
            // 
            // bonusLabel
            // 
            bonusLabel.BackColor = Color.Maroon;
            bonusLabel.ForeColor = Color.White;
            bonusLabel.Location = new Point(12, 561);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(376, 101);
            bonusLabel.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1029, 671);
            Controls.Add(bonusLabel);
            Controls.Add(bonusButton);
            Controls.Add(q5InstructButton);
            Controls.Add(label13);
            Controls.Add(q5Button);
            Controls.Add(panel4);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(q3Button);
            Controls.Add(q4TextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(q2Button);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(q1Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Quiz 04 - Looping!";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label q1OutputLabel;
        private Button q1Button;
        private Panel panel1;
        private Panel panel2;
        private Label q2OutputLabel;
        private Button q2Button;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox q4TextBox;
        private Button q3Button;
        private Label q4OutputLabel;
        private Panel panel3;
        private Label label12;
        private Panel panel4;
        private Label q5OutputLabel;
        private Button q5Button;
        private Label label13;
        private Button q5InstructButton;
        private Button bonusButton;
        private Label bonusLabel;
    }
}
