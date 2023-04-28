
namespace AIR3550
{
    partial class loginPage
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
            this.Login = new System.Windows.Forms.Button();
            this.CreateNewAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordPrompt = new System.Windows.Forms.TextBox();
            this.UsernamePrompt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(241, 261);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(101, 30);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // CreateNewAccount
            // 
            this.CreateNewAccount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAccount.Location = new System.Drawing.Point(218, 339);
            this.CreateNewAccount.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewAccount.Name = "CreateNewAccount";
            this.CreateNewAccount.Size = new System.Drawing.Size(145, 31);
            this.CreateNewAccount.TabIndex = 14;
            this.CreateNewAccount.Text = "Create New Account";
            this.CreateNewAccount.UseVisualStyleBackColor = true;
            this.CreateNewAccount.Click += new System.EventHandler(this.CreateNewAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dont have an existing account?";
            // 
            // PasswordPrompt
            // 
            this.PasswordPrompt.Location = new System.Drawing.Point(301, 184);
            this.PasswordPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordPrompt.Name = "PasswordPrompt";
            this.PasswordPrompt.PasswordChar = '*';
            this.PasswordPrompt.Size = new System.Drawing.Size(127, 20);
            this.PasswordPrompt.TabIndex = 12;
            this.PasswordPrompt.TextChanged += new System.EventHandler(this.PasswordPrompt_text);
            // 
            // UsernamePrompt
            // 
            this.UsernamePrompt.BackColor = System.Drawing.SystemColors.Window;
            this.UsernamePrompt.Location = new System.Drawing.Point(300, 126);
            this.UsernamePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.UsernamePrompt.Name = "UsernamePrompt";
            this.UsernamePrompt.Size = new System.Drawing.Size(127, 20);
            this.UsernamePrompt.TabIndex = 11;
            this.UsernamePrompt.TextChanged += new System.EventHandler(this.UsernamePrompt_text);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to Air3550!";
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIR3550.Properties.Resources.plane;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 421);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.CreateNewAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordPrompt);
            this.Controls.Add(this.UsernamePrompt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginPage";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button CreateNewAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordPrompt;
        private System.Windows.Forms.TextBox UsernamePrompt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

