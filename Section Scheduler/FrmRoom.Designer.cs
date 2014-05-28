namespace Section_Scheduler
{
    partial class FrmRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkLaboratory = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAvailability = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lstRoom = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsLab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 1;
            // 
            // chkLaboratory
            // 
            this.chkLaboratory.AutoSize = true;
            this.chkLaboratory.Location = new System.Drawing.Point(93, 94);
            this.chkLaboratory.Name = "chkLaboratory";
            this.chkLaboratory.Size = new System.Drawing.Size(15, 14);
            this.chkLaboratory.TabIndex = 2;
            this.chkLaboratory.UseVisualStyleBackColor = true;
            this.chkLaboratory.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laboratory";
            // 
            // chkAvailability
            // 
            this.chkAvailability.AutoSize = true;
            this.chkAvailability.Location = new System.Drawing.Point(93, 131);
            this.chkAvailability.Name = "chkAvailability";
            this.chkAvailability.Size = new System.Drawing.Size(15, 14);
            this.chkAvailability.TabIndex = 4;
            this.chkAvailability.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Availability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAvailability);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkLaboratory);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Room";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(161, 127);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 6;
            this.btnAddRoom.Text = "AddRoom";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // lstRoom
            // 
            this.lstRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colIsLab,
            this.colIsAvailable});
            this.lstRoom.GridLines = true;
            this.lstRoom.Location = new System.Drawing.Point(309, 54);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(418, 486);
            this.lstRoom.TabIndex = 7;
            this.lstRoom.UseCompatibleStateImageBehavior = false;
            this.lstRoom.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colIsLab
            // 
            this.colIsLab.Text = "Laboratory";
            this.colIsLab.Width = 114;
            // 
            // colIsAvailable
            // 
            this.colIsAvailable.Text = "Availbaility";
            this.colIsAvailable.Width = 133;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 576);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRoom";
            this.Text = "Room";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkLaboratory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAvailability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ListView lstRoom;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colIsLab;
        private System.Windows.Forms.ColumnHeader colIsAvailable;
    }
}