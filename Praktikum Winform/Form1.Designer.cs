namespace Praktikum_Winform
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            ButtonLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("GAMERIA", 59.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 101);
            label1.Name = "label1";
            label1.Size = new Size(335, 83);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.FromArgb(224, 224, 224);
            UsernameBox.Font = new Font("Segoe UI", 14F);
            UsernameBox.Location = new Point(575, 316);
            UsernameBox.Margin = new Padding(3, 4, 3, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(473, 39);
            UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(224, 224, 224);
            PasswordBox.Font = new Font("Segoe UI", 14F);
            PasswordBox.Location = new Point(575, 427);
            PasswordBox.Margin = new Padding(3, 4, 3, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(473, 39);
            PasswordBox.TabIndex = 2;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.Location = new Point(750, 500);
            ButtonLogin.Margin = new Padding(3, 4, 3, 4);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(105, 55);
            ButtonLogin.TabIndex = 3;
            ButtonLogin.TabStop = false;
            ButtonLogin.Text = "Log In";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            label2.Location = new Point(575, 276);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            label3.Location = new Point(575, 387);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1699, 837);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtonLogin);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button ButtonLogin;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
