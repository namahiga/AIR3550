using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AIR3550
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZipCodeText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DOBText = new System.Windows.Forms.MaskedTextBox();
            this.Signup_Button = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.LNameText = new System.Windows.Forms.TextBox();
            this.MNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.StateText = new System.Windows.Forms.TextBox();
            this.PhoneNumText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.FNameText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Female);
            this.panel1.Controls.Add(this.Male);
            this.panel1.Controls.Add(this.ZipCodeText);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.DOBText);
            this.panel1.Controls.Add(this.Signup_Button);
            this.panel1.Controls.Add(this.PassText);
            this.panel1.Controls.Add(this.UserText);
            this.panel1.Controls.Add(this.LNameText);
            this.panel1.Controls.Add(this.MNameText);
            this.panel1.Controls.Add(this.AddressText);
            this.panel1.Controls.Add(this.CityText);
            this.panel1.Controls.Add(this.StateText);
            this.panel1.Controls.Add(this.PhoneNumText);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.FNameText);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(80, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 529);
            this.panel1.TabIndex = 0;
            // 
            // ZipCodeText
            // 
            this.ZipCodeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZipCodeText.Location = new System.Drawing.Point(124, 269);
            this.ZipCodeText.Margin = new System.Windows.Forms.Padding(2);
            this.ZipCodeText.Name = "ZipCodeText";
            this.ZipCodeText.Size = new System.Drawing.Size(86, 20);
            this.ZipCodeText.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkKhaki;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(37, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "ZipCode";
            // 
            // DOBText
            // 
            this.DOBText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DOBText.Location = new System.Drawing.Point(124, 117);
            this.DOBText.Margin = new System.Windows.Forms.Padding(2);
            this.DOBText.Mask = "00/00/0000";
            this.DOBText.Name = "DOBText";
            this.DOBText.Size = new System.Drawing.Size(255, 20);
            this.DOBText.TabIndex = 13;
            // 
            // Signup_Button
            // 
            this.Signup_Button.BackColor = System.Drawing.Color.Khaki;
            this.Signup_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Signup_Button.Location = new System.Drawing.Point(151, 491);
            this.Signup_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Signup_Button.Name = "Signup_Button";
            this.Signup_Button.Size = new System.Drawing.Size(108, 31);
            this.Signup_Button.TabIndex = 23;
            this.Signup_Button.Text = "SignUp";
            this.Signup_Button.UseVisualStyleBackColor = false;
            this.Signup_Button.Click += new System.EventHandler(this.Signup_Button_Click);
            // 
            // PassText
            // 
            this.PassText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassText.Location = new System.Drawing.Point(124, 457);
            this.PassText.Margin = new System.Windows.Forms.Padding(2);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(255, 20);
            this.PassText.TabIndex = 22;
            // 
            // UserText
            // 
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserText.Location = new System.Drawing.Point(124, 418);
            this.UserText.Margin = new System.Windows.Forms.Padding(2);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(255, 20);
            this.UserText.TabIndex = 21;
            // 
            // LNameText
            // 
            this.LNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNameText.Location = new System.Drawing.Point(124, 83);
            this.LNameText.Margin = new System.Windows.Forms.Padding(2);
            this.LNameText.Name = "LNameText";
            this.LNameText.Size = new System.Drawing.Size(255, 20);
            this.LNameText.TabIndex = 12;
            // 
            // MNameText
            // 
            this.MNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MNameText.Location = new System.Drawing.Point(124, 44);
            this.MNameText.Margin = new System.Windows.Forms.Padding(2);
            this.MNameText.Name = "MNameText";
            this.MNameText.Size = new System.Drawing.Size(255, 20);
            this.MNameText.TabIndex = 11;
            // 
            // AddressText
            // 
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressText.Location = new System.Drawing.Point(124, 153);
            this.AddressText.Margin = new System.Windows.Forms.Padding(2);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(255, 20);
            this.AddressText.TabIndex = 14;
            // 
            // CityText
            // 
            this.CityText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityText.Location = new System.Drawing.Point(124, 191);
            this.CityText.Margin = new System.Windows.Forms.Padding(2);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(255, 20);
            this.CityText.TabIndex = 15;
            // 
            // StateText
            // 
            this.StateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateText.Location = new System.Drawing.Point(124, 230);
            this.StateText.Margin = new System.Windows.Forms.Padding(2);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(255, 20);
            this.StateText.TabIndex = 16;
            // 
            // PhoneNumText
            // 
            this.PhoneNumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumText.Location = new System.Drawing.Point(124, 308);
            this.PhoneNumText.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumText.Name = "PhoneNumText";
            this.PhoneNumText.Size = new System.Drawing.Size(255, 20);
            this.PhoneNumText.TabIndex = 18;
            // 
            // EmailText
            // 
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailText.Location = new System.Drawing.Point(124, 345);
            this.EmailText.Margin = new System.Windows.Forms.Padding(2);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(255, 20);
            this.EmailText.TabIndex = 19;
            // 
            // FNameText
            // 
            this.FNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameText.Location = new System.Drawing.Point(124, 10);
            this.FNameText.Margin = new System.Windows.Forms.Padding(2);
            this.FNameText.Name = "FNameText";
            this.FNameText.Size = new System.Drawing.Size(255, 20);
            this.FNameText.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkKhaki;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(23, 418);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkKhaki;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(28, 457);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(43, 380);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkKhaki;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(37, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkKhaki;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(38, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkKhaki;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(58, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkKhaki;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(71, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(38, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkKhaki;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(81, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SignUp!";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(136, 383);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 24;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(217, 382);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 25;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIR3550.Properties.Resources.clouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Signup_Button;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PhoneNumText;
        private System.Windows.Forms.TextBox ZipCodeText;
        private System.Windows.Forms.TextBox StateText;
        private System.Windows.Forms.TextBox CityText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.MaskedTextBox DOBText;
        private System.Windows.Forms.TextBox LNameText;
        private System.Windows.Forms.TextBox MNameText;
        private System.Windows.Forms.TextBox FNameText;
        private Label label14;
        private RadioButton Female;
        private RadioButton Male;
    }
}