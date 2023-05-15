namespace WinFormsApp1
{
    partial class Selection
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(134, 26);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose a Seans to the movie...";
            // 
            // button1
            // 
            button1.Location = new Point(39, 99);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 1;
            button1.Text = "08:00-10:45";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 99);
            button2.Name = "button2";
            button2.Size = new Size(176, 49);
            button2.TabIndex = 1;
            button2.Text = "11:00-13:45";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(39, 204);
            button3.Name = "button3";
            button3.Size = new Size(176, 49);
            button3.TabIndex = 1;
            button3.Text = "14:00-16:45";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(277, 204);
            button4.Name = "button4";
            button4.Size = new Size(176, 49);
            button4.TabIndex = 1;
            button4.Text = "17:00-19:45";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(39, 311);
            button5.Name = "button5";
            button5.Size = new Size(176, 49);
            button5.TabIndex = 1;
            button5.Text = "20:00-22:45";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(277, 311);
            button6.Name = "button6";
            button6.Size = new Size(176, 49);
            button6.TabIndex = 1;
            button6.Text = "23:00-01:45";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 391);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Selection";
            Text = "Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}