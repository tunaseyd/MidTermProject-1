namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(39, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 267);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(309, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 267);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(587, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 267);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.Location = new Point(39, 351);
            button4.Name = "button4";
            button4.Size = new Size(163, 27);
            button4.TabIndex = 2;
            button4.Text = "Check";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(309, 351);
            button5.Name = "button5";
            button5.Size = new Size(163, 27);
            button5.TabIndex = 2;
            button5.Text = "Check";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(587, 351);
            button6.Name = "button6";
            button6.Size = new Size(163, 27);
            button6.TabIndex = 2;
            button6.Text = "Check";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 25);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 3;
            label1.Text = "Full Metal Jacket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 25);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 3;
            label2.Text = "Saving Private Ryan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Constantine";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}