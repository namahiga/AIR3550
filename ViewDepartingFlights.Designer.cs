
namespace AIR3550
{
    partial class ViewDepartingFlights
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
            this.F1Time_D = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F1Duration_D = new System.Windows.Forms.TextBox();
            this.F2Duration_D = new System.Windows.Forms.TextBox();
            this.F3Duration_D = new System.Windows.Forms.TextBox();
            this.F3Time_D = new System.Windows.Forms.TextBox();
            this.F2Time_D = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.F1radioButton_D = new System.Windows.Forms.RadioButton();
            this.F2radioButton_D = new System.Windows.Forms.RadioButton();
            this.F3radioButton_D = new System.Windows.Forms.RadioButton();
            this.NextButton_D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F1Time_D
            // 
            this.F1Time_D.Location = new System.Drawing.Point(106, 212);
            this.F1Time_D.Name = "F1Time_D";
            this.F1Time_D.Size = new System.Drawing.Size(100, 26);
            this.F1Time_D.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Best Departing Flights";
            // 
            // F1Duration_D
            // 
            this.F1Duration_D.Location = new System.Drawing.Point(633, 212);
            this.F1Duration_D.Name = "F1Duration_D";
            this.F1Duration_D.Size = new System.Drawing.Size(100, 26);
            this.F1Duration_D.TabIndex = 3;
            // 
            // F2Duration_D
            // 
            this.F2Duration_D.Location = new System.Drawing.Point(633, 356);
            this.F2Duration_D.Name = "F2Duration_D";
            this.F2Duration_D.Size = new System.Drawing.Size(100, 26);
            this.F2Duration_D.TabIndex = 4;
            // 
            // F3Duration_D
            // 
            this.F3Duration_D.Location = new System.Drawing.Point(633, 523);
            this.F3Duration_D.Name = "F3Duration_D";
            this.F3Duration_D.Size = new System.Drawing.Size(100, 26);
            this.F3Duration_D.TabIndex = 6;
            // 
            // F3Time_D
            // 
            this.F3Time_D.Location = new System.Drawing.Point(106, 523);
            this.F3Time_D.Name = "F3Time_D";
            this.F3Time_D.Size = new System.Drawing.Size(100, 26);
            this.F3Time_D.TabIndex = 7;
            // 
            // F2Time_D
            // 
            this.F2Time_D.Location = new System.Drawing.Point(106, 356);
            this.F2Time_D.Name = "F2Time_D";
            this.F2Time_D.Size = new System.Drawing.Size(100, 26);
            this.F2Time_D.TabIndex = 9;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(81, 139);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(279, 29);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Departure-Arrival Time";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(620, 139);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(184, 29);
            this.DurationLabel.TabIndex = 11;
            this.DurationLabel.Text = "Flight Duration";
            // 
            // F1radioButton_D
            // 
            this.F1radioButton_D.AutoSize = true;
            this.F1radioButton_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1radioButton_D.Location = new System.Drawing.Point(1008, 212);
            this.F1radioButton_D.Name = "F1radioButton_D";
            this.F1radioButton_D.Size = new System.Drawing.Size(303, 30);
            this.F1radioButton_D.TabIndex = 12;
            this.F1radioButton_D.TabStop = true;
            this.F1radioButton_D.Text = "Select This Departing Flight";
            this.F1radioButton_D.UseVisualStyleBackColor = true;
            // 
            // F2radioButton_D
            // 
            this.F2radioButton_D.AutoSize = true;
            this.F2radioButton_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2radioButton_D.Location = new System.Drawing.Point(1008, 356);
            this.F2radioButton_D.Name = "F2radioButton_D";
            this.F2radioButton_D.Size = new System.Drawing.Size(303, 30);
            this.F2radioButton_D.TabIndex = 13;
            this.F2radioButton_D.TabStop = true;
            this.F2radioButton_D.Text = "Select This Departing Flight";
            this.F2radioButton_D.UseVisualStyleBackColor = true;
            this.F2radioButton_D.CheckedChanged += new System.EventHandler(this.F2RadioButton_D_CheckedChanged);
            // 
            // F3radioButton_D
            // 
            this.F3radioButton_D.AutoSize = true;
            this.F3radioButton_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F3radioButton_D.Location = new System.Drawing.Point(1008, 511);
            this.F3radioButton_D.Name = "F3radioButton_D";
            this.F3radioButton_D.Size = new System.Drawing.Size(303, 30);
            this.F3radioButton_D.TabIndex = 14;
            this.F3radioButton_D.TabStop = true;
            this.F3radioButton_D.Text = "Select This Departing Flight";
            this.F3radioButton_D.UseVisualStyleBackColor = true;
            // 
            // NextButton_D
            // 
            this.NextButton_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButton_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton_D.Location = new System.Drawing.Point(1147, 633);
            this.NextButton_D.Name = "NextButton_D";
            this.NextButton_D.Size = new System.Drawing.Size(145, 60);
            this.NextButton_D.TabIndex = 15;
            this.NextButton_D.Text = "NEXT";
            this.NextButton_D.UseVisualStyleBackColor = true;
            // 
            // ViewDeparting_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIR3550.Properties.Resources.clouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.NextButton_D);
            this.Controls.Add(this.F3radioButton_D);
            this.Controls.Add(this.F2radioButton_D);
            this.Controls.Add(this.F1radioButton_D);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.F2Time_D);
            this.Controls.Add(this.F3Time_D);
            this.Controls.Add(this.F3Duration_D);
            this.Controls.Add(this.F2Duration_D);
            this.Controls.Add(this.F1Duration_D);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F1Time_D);
            this.Name = "ViewDeparting_Flights";
            this.Text = "ViewDeparting_Flights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F1Time_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F1Duration_D;
        private System.Windows.Forms.TextBox F2Duration_D;
        private System.Windows.Forms.TextBox F3Duration_D;
        private System.Windows.Forms.TextBox F3Time_D;
        private System.Windows.Forms.TextBox F2Time_D;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.RadioButton F1radioButton_D;
        private System.Windows.Forms.RadioButton F2radioButton_D;
        private System.Windows.Forms.RadioButton F3radioButton_D;
        private System.Windows.Forms.Button NextButton_D;
    }
}