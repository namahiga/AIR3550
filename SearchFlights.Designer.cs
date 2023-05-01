namespace AIR3550
{
    partial class SearchFlights
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBoardingPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookedFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tripTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchFlightButton = new System.Windows.Forms.Button();
            this.arrivalCalendar = new System.Windows.Forms.MonthCalendar();
            this.departureCalendar = new System.Windows.Forms.MonthCalendar();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.departDateLabel = new System.Windows.Forms.Label();
            this.noOfPassengersValue = new System.Windows.Forms.NumericUpDown();
            this.passengersLabel = new System.Windows.Forms.Label();
            this.departPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.arrivePlaceComboBox = new System.Windows.Forms.ComboBox();
            this.arrivePlaceLabel = new System.Windows.Forms.Label();
            this.departPlaceLabel = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfPassengersValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuBar.Size = new System.Drawing.Size(971, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPointsToolStripMenuItem,
            this.editAccountInfoToolStripMenuItem,
            this.myFlightsToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // viewPointsToolStripMenuItem
            // 
            this.viewPointsToolStripMenuItem.Name = "viewPointsToolStripMenuItem";
            this.viewPointsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewPointsToolStripMenuItem.Text = "View Points";
            // 
            // editAccountInfoToolStripMenuItem
            // 
            this.editAccountInfoToolStripMenuItem.Name = "editAccountInfoToolStripMenuItem";
            this.editAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editAccountInfoToolStripMenuItem.Text = "Edit Account Info";
            this.editAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.editAccountInfoToolStripMenuItem_Click);
            // 
            // myFlightsToolStripMenuItem
            // 
            this.myFlightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelFlightToolStripMenuItem,
            this.printBoardingPassToolStripMenuItem,
            this.viewBookedFlightToolStripMenuItem});
            this.myFlightsToolStripMenuItem.Name = "myFlightsToolStripMenuItem";
            this.myFlightsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.myFlightsToolStripMenuItem.Text = "My flights";
            // 
            // cancelFlightToolStripMenuItem
            // 
            this.cancelFlightToolStripMenuItem.Name = "cancelFlightToolStripMenuItem";
            this.cancelFlightToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cancelFlightToolStripMenuItem.Text = "Cancel flight";
            this.cancelFlightToolStripMenuItem.Click += new System.EventHandler(this.cancelFlightToolStripMenuItem_Click);
            // 
            // printBoardingPassToolStripMenuItem
            // 
            this.printBoardingPassToolStripMenuItem.Name = "printBoardingPassToolStripMenuItem";
            this.printBoardingPassToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.printBoardingPassToolStripMenuItem.Text = "Print Boarding Pass";
            // 
            // viewBookedFlightToolStripMenuItem
            // 
            this.viewBookedFlightToolStripMenuItem.Name = "viewBookedFlightToolStripMenuItem";
            this.viewBookedFlightToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewBookedFlightToolStripMenuItem.Text = "View Booked Flight";
            this.viewBookedFlightToolStripMenuItem.Click += new System.EventHandler(this.viewBookedFlightToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Flights";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.tripTypeComboBox);
            this.panel1.Controls.Add(this.SearchFlightButton);
            this.panel1.Controls.Add(this.arrivalCalendar);
            this.panel1.Controls.Add(this.departureCalendar);
            this.panel1.Controls.Add(this.arrivalDateLabel);
            this.panel1.Controls.Add(this.departDateLabel);
            this.panel1.Controls.Add(this.noOfPassengersValue);
            this.panel1.Controls.Add(this.passengersLabel);
            this.panel1.Controls.Add(this.departPlaceComboBox);
            this.panel1.Controls.Add(this.arrivePlaceComboBox);
            this.panel1.Controls.Add(this.arrivePlaceLabel);
            this.panel1.Controls.Add(this.departPlaceLabel);
            this.panel1.Location = new System.Drawing.Point(129, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 489);
            this.panel1.TabIndex = 2;
            // 
            // tripTypeComboBox
            // 
            this.tripTypeComboBox.FormattingEnabled = true;
            this.tripTypeComboBox.Items.AddRange(new object[] {
            "Round-trip",
            "One-way"});
            this.tripTypeComboBox.Location = new System.Drawing.Point(101, 25);
            this.tripTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tripTypeComboBox.Name = "tripTypeComboBox";
            this.tripTypeComboBox.Size = new System.Drawing.Size(82, 21);
            this.tripTypeComboBox.TabIndex = 14;
            this.tripTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.tripTypeComboBox_SelectedIndexChanged_1);
            // 
            // SearchFlightButton
            // 
            this.SearchFlightButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFlightButton.Location = new System.Drawing.Point(264, 437);
            this.SearchFlightButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFlightButton.Name = "SearchFlightButton";
            this.SearchFlightButton.Size = new System.Drawing.Size(87, 31);
            this.SearchFlightButton.TabIndex = 13;
            this.SearchFlightButton.Text = "Search ";
            this.SearchFlightButton.UseVisualStyleBackColor = true;
            this.SearchFlightButton.Click += new System.EventHandler(this.SearchFlightButton_Click);
            // 
            // arrivalCalendar
            // 
            this.arrivalCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.arrivalCalendar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.arrivalCalendar.Location = new System.Drawing.Point(353, 251);
            this.arrivalCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.arrivalCalendar.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.arrivalCalendar.MinDate = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            this.arrivalCalendar.Name = "arrivalCalendar";
            this.arrivalCalendar.ShowToday = false;
            this.arrivalCalendar.ShowTodayCircle = false;
            this.arrivalCalendar.TabIndex = 10;
            // 
            // departureCalendar
            // 
            this.departureCalendar.BackColor = System.Drawing.Color.PapayaWhip;
            this.departureCalendar.Location = new System.Drawing.Point(55, 251);
            this.departureCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.departureCalendar.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.departureCalendar.MinDate = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            this.departureCalendar.Name = "departureCalendar";
            this.departureCalendar.ShowToday = false;
            this.departureCalendar.ShowTodayCircle = false;
            this.departureCalendar.TabIndex = 9;
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.BackColor = System.Drawing.Color.White;
            this.arrivalDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDateLabel.Location = new System.Drawing.Point(415, 226);
            this.arrivalDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(86, 19);
            this.arrivalDateLabel.TabIndex = 8;
            this.arrivalDateLabel.Text = "Arrival Date";
            // 
            // departDateLabel
            // 
            this.departDateLabel.AutoSize = true;
            this.departDateLabel.BackColor = System.Drawing.Color.White;
            this.departDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departDateLabel.Location = new System.Drawing.Point(111, 226);
            this.departDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departDateLabel.Name = "departDateLabel";
            this.departDateLabel.Size = new System.Drawing.Size(88, 19);
            this.departDateLabel.TabIndex = 7;
            this.departDateLabel.Text = "Depart Date";
            // 
            // noOfPassengersValue
            // 
            this.noOfPassengersValue.Location = new System.Drawing.Point(385, 25);
            this.noOfPassengersValue.Margin = new System.Windows.Forms.Padding(2);
            this.noOfPassengersValue.Name = "noOfPassengersValue";
            this.noOfPassengersValue.Size = new System.Drawing.Size(80, 20);
            this.noOfPassengersValue.TabIndex = 6;
            // 
            // passengersLabel
            // 
            this.passengersLabel.AutoSize = true;
            this.passengersLabel.BackColor = System.Drawing.Color.White;
            this.passengersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersLabel.Location = new System.Drawing.Point(280, 22);
            this.passengersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passengersLabel.Name = "passengersLabel";
            this.passengersLabel.Size = new System.Drawing.Size(83, 19);
            this.passengersLabel.TabIndex = 5;
            this.passengersLabel.Text = "Passengers";
            // 
            // departPlaceComboBox
            // 
            this.departPlaceComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.departPlaceComboBox.FormattingEnabled = true;
            this.departPlaceComboBox.Location = new System.Drawing.Point(175, 97);
            this.departPlaceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.departPlaceComboBox.Name = "departPlaceComboBox";
            this.departPlaceComboBox.Size = new System.Drawing.Size(82, 21);
            this.departPlaceComboBox.TabIndex = 4;
            // 
            // arrivePlaceComboBox
            // 
            this.arrivePlaceComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arrivePlaceComboBox.FormattingEnabled = true;
            this.arrivePlaceComboBox.Location = new System.Drawing.Point(421, 98);
            this.arrivePlaceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.arrivePlaceComboBox.Name = "arrivePlaceComboBox";
            this.arrivePlaceComboBox.Size = new System.Drawing.Size(82, 21);
            this.arrivePlaceComboBox.TabIndex = 3;
            this.arrivePlaceComboBox.SelectedIndexChanged += new System.EventHandler(this.arrivePlaceComboBox_SelectedIndexChanged);
            // 
            // arrivePlaceLabel
            // 
            this.arrivePlaceLabel.AutoSize = true;
            this.arrivePlaceLabel.BackColor = System.Drawing.Color.White;
            this.arrivePlaceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivePlaceLabel.Location = new System.Drawing.Point(350, 97);
            this.arrivePlaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivePlaceLabel.Name = "arrivePlaceLabel";
            this.arrivePlaceLabel.Size = new System.Drawing.Size(47, 19);
            this.arrivePlaceLabel.TabIndex = 1;
            this.arrivePlaceLabel.Text = "Arrive";
            // 
            // departPlaceLabel
            // 
            this.departPlaceLabel.AutoSize = true;
            this.departPlaceLabel.BackColor = System.Drawing.Color.White;
            this.departPlaceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departPlaceLabel.Location = new System.Drawing.Point(97, 94);
            this.departPlaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departPlaceLabel.Name = "departPlaceLabel";
            this.departPlaceLabel.Size = new System.Drawing.Size(53, 19);
            this.departPlaceLabel.TabIndex = 0;
            this.departPlaceLabel.Text = "Depart";
            // 
            // SearchFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIR3550.Properties.Resources.clouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchFlights";
            this.Text = "SearchFlights";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfPassengersValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBoardingPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookedFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar arrivalCalendar;
        private System.Windows.Forms.MonthCalendar departureCalendar;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label departDateLabel;
        private System.Windows.Forms.NumericUpDown noOfPassengersValue;
        private System.Windows.Forms.Label passengersLabel;
        private System.Windows.Forms.ComboBox departPlaceComboBox;
        private System.Windows.Forms.ComboBox arrivePlaceComboBox;
        private System.Windows.Forms.Label arrivePlaceLabel;
        private System.Windows.Forms.Label departPlaceLabel;
        private System.Windows.Forms.Button SearchFlightButton;
        private System.Windows.Forms.ComboBox tripTypeComboBox;
    }
}

