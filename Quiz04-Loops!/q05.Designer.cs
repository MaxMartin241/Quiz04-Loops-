namespace Quiz04_Loops_
{
    partial class q05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q05));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            returnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nestedLoop;
            pictureBox1.Location = new Point(102, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(319, 59);
            label1.TabIndex = 1;
            label1.Text = "Use a nested loop (a loop inside a loop) to create this number pattern in the output label.  ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.ForeColor = Color.Maroon;
            returnButton.Location = new Point(262, 196);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(92, 66);
            returnButton.TabIndex = 2;
            returnButton.Text = "Return to quiz form";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // q05
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(366, 274);
            Controls.Add(returnButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "q05";
            Text = "q05";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button returnButton;
    }
}