namespace resturantManagment
{
    partial class Tables
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
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.radReserved = new System.Windows.Forms.RadioButton();
            this.radOccupied = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStat3 = new System.Windows.Forms.Panel();
            this.lblReservedCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelStat2 = new System.Windows.Forms.Panel();
            this.lblOccupiedCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelStat1 = new System.Windows.Forms.Panel();
            this.lblTotalTables = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelStat3.SuspendLayout();
            this.panelStat2.SuspendLayout();
            this.panelStat1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeStatus);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panelStatus);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTableNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnChangeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(232, 384);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(118, 36);
            this.btnChangeStatus.TabIndex = 17;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(114, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Table";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Table";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.radReserved);
            this.panelStatus.Controls.Add(this.radOccupied);
            this.panelStatus.Controls.Add(this.radAvailable);
            this.panelStatus.Controls.Add(this.label8);
            this.panelStatus.Location = new System.Drawing.Point(8, 215);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(331, 138);
            this.panelStatus.TabIndex = 14;
            // 
            // radReserved
            // 
            this.radReserved.AutoSize = true;
            this.radReserved.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radReserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.radReserved.Location = new System.Drawing.Point(20, 90);
            this.radReserved.Name = "radReserved";
            this.radReserved.Size = new System.Drawing.Size(90, 24);
            this.radReserved.TabIndex = 3;
            this.radReserved.TabStop = true;
            this.radReserved.Text = "Reserved";
            this.radReserved.UseVisualStyleBackColor = true;
            // 
            // radOccupied
            // 
            this.radOccupied.AutoSize = true;
            this.radOccupied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.radOccupied.Location = new System.Drawing.Point(20, 60);
            this.radOccupied.Name = "radOccupied";
            this.radOccupied.Size = new System.Drawing.Size(93, 24);
            this.radOccupied.TabIndex = 2;
            this.radOccupied.TabStop = true;
            this.radOccupied.Text = "Occupied";
            this.radOccupied.UseVisualStyleBackColor = true;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Checked = true;
            this.radAvailable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.radAvailable.Location = new System.Drawing.Point(20, 30);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(92, 24);
            this.radAvailable.TabIndex = 1;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Available";
            this.radAvailable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(20, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Table Status";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLocation
            // 
            this.cmbLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Main Hall",
            "Terrace",
            "Private Room",
            "Garden",
            "Bar Area",
            "Smoking Section"});
            this.cmbLocation.Location = new System.Drawing.Point(186, 167);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(153, 33);
            this.cmbLocation.TabIndex = 13;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCapacity.Location = new System.Drawing.Point(8, 168);
            this.txtCapacity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(153, 32);
            this.txtCapacity.TabIndex = 12;
            this.txtCapacity.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(186, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Location";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Capacity (Persons)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtTableNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTableNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTableNumber.Location = new System.Drawing.Point(8, 59);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(331, 32);
            this.txtTableNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelStat3);
            this.panel2.Controls.Add(this.panelStat2);
            this.panel2.Controls.Add(this.panelStat1);
            this.panel2.Location = new System.Drawing.Point(396, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 468);
            this.panel2.TabIndex = 1;
            // 
            // panelStat3
            // 
            this.panelStat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.panelStat3.Controls.Add(this.lblReservedCount);
            this.panelStat3.Controls.Add(this.label5);
            this.panelStat3.Location = new System.Drawing.Point(322, 12);
            this.panelStat3.Name = "panelStat3";
            this.panelStat3.Size = new System.Drawing.Size(136, 69);
            this.panelStat3.TabIndex = 3;
            // 
            // lblReservedCount
            // 
            this.lblReservedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedCount.ForeColor = System.Drawing.Color.White;
            this.lblReservedCount.Location = new System.Drawing.Point(52, 30);
            this.lblReservedCount.Name = "lblReservedCount";
            this.lblReservedCount.Size = new System.Drawing.Size(39, 29);
            this.lblReservedCount.TabIndex = 1;
            this.lblReservedCount.Text = "5";
            this.lblReservedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reserved";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStat2
            // 
            this.panelStat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.panelStat2.Controls.Add(this.lblOccupiedCount);
            this.panelStat2.Controls.Add(this.label4);
            this.panelStat2.Location = new System.Drawing.Point(165, 12);
            this.panelStat2.Name = "panelStat2";
            this.panelStat2.Size = new System.Drawing.Size(135, 69);
            this.panelStat2.TabIndex = 2;
            // 
            // lblOccupiedCount
            // 
            this.lblOccupiedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedCount.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedCount.Location = new System.Drawing.Point(40, 26);
            this.lblOccupiedCount.Name = "lblOccupiedCount";
            this.lblOccupiedCount.Size = new System.Drawing.Size(37, 43);
            this.lblOccupiedCount.TabIndex = 1;
            this.lblOccupiedCount.Text = "12";
            this.lblOccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Occupied";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStat1
            // 
            this.panelStat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.panelStat1.Controls.Add(this.lblTotalTables);
            this.panelStat1.Controls.Add(this.label3);
            this.panelStat1.Location = new System.Drawing.Point(12, 12);
            this.panelStat1.Name = "panelStat1";
            this.panelStat1.Size = new System.Drawing.Size(135, 69);
            this.panelStat1.TabIndex = 1;
            this.panelStat1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStat1_Paint);
            // 
            // lblTotalTables
            // 
            this.lblTotalTables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTables.ForeColor = System.Drawing.Color.White;
            this.lblTotalTables.Location = new System.Drawing.Point(41, 26);
            this.lblTotalTables.Name = "lblTotalTables";
            this.lblTotalTables.Size = new System.Drawing.Size(81, 43);
            this.lblTotalTables.TabIndex = 1;
            this.lblTotalTables.Text = "25";
            this.lblTotalTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Tables";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(895, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tfrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelStat3.ResumeLayout(false);
            this.panelStat2.ResumeLayout(false);
            this.panelStat1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStat1;
        private System.Windows.Forms.Label lblTotalTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStat2;
        private System.Windows.Forms.Label lblOccupiedCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelStat3;
        private System.Windows.Forms.Label lblReservedCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtCapacity;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.RadioButton radReserved;
        private System.Windows.Forms.RadioButton radOccupied;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeStatus;
    }
}