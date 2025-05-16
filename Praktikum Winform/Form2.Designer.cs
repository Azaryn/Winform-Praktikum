namespace Praktikum_Winform
{
    partial class Form2
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
            SapaUsername = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("GAMERIA", 50.2499924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 51);
            label1.Name = "label1";
            label1.Size = new Size(377, 56);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // SapaUsername
            // 
            SapaUsername.AutoSize = true;
            SapaUsername.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SapaUsername.Location = new Point(456, 145);
            SapaUsername.Name = "SapaUsername";
            SapaUsername.Size = new Size(149, 28);
            SapaUsername.TabIndex = 1;
            SapaUsername.Text = "SapaUsername";
            SapaUsername.UseMnemonic = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 562);
            Controls.Add(SapaUsername);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label SapaUsername;
    }
}