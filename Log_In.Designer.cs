namespace WinFormsApp1
{
    partial class Log_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Sname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            Username = new Label();
            OutputLabel = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(163, 66);
            Username.Margin = new Padding(4, 0, 4, 0);
            Username.Name = "Username";
            Username.Size = new Size(69, 17);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(16, 354);
            OutputLabel.Margin = new Padding(4, 0, 4, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(0, 20);
            OutputLabel.TabIndex = 0;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameBox.Location = new Point(133, 118);
            UsernameBox.Margin = new Padding(4, 5, 4, 5);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(132, 25);
            UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(133, 229);
            PasswordBox.Margin = new Padding(4, 5, 4, 5);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(132, 25);
            PasswordBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(159, 288);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(379, 435);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(OutputLabel);
            Controls.Add(Username);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Log_In";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}