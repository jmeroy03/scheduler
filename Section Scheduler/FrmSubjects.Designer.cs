namespace Section_Scheduler
{
    partial class FrmSubjects
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
            this.lstSubjects = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsLaboratory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsServiceCourse = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAvailablity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLaboratory = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubjects
            // 
            this.lstSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.colUnits,
            this.colIsLaboratory,
            this.colClassification,
            this.colAvailability});
            this.lstSubjects.FullRowSelect = true;
            this.lstSubjects.GridLines = true;
            this.lstSubjects.LabelWrap = false;
            this.lstSubjects.Location = new System.Drawing.Point(372, 12);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(473, 545);
            this.lstSubjects.TabIndex = 0;
            this.lstSubjects.UseCompatibleStateImageBehavior = false;
            this.lstSubjects.View = System.Windows.Forms.View.Details;
            this.lstSubjects.SelectedIndexChanged += new System.EventHandler(this.lstSubjects_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            // 
            // colUnits
            // 
            this.colUnits.Text = "Units";
            // 
            // colIsLaboratory
            // 
            this.colIsLaboratory.Text = "Is Laboratory";
            // 
            // colClassification
            // 
            this.colClassification.Text = "Service Course";
            // 
            // colAvailability
            // 
            this.colAvailability.Text = "Availability";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkIsServiceCourse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboAvailablity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkLaboratory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUnits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Course";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(127, 189);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 12;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Service Course:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkIsServiceCourse
            // 
            this.chkIsServiceCourse.AutoSize = true;
            this.chkIsServiceCourse.Location = new System.Drawing.Point(127, 169);
            this.chkIsServiceCourse.Name = "chkIsServiceCourse";
            this.chkIsServiceCourse.Size = new System.Drawing.Size(15, 14);
            this.chkIsServiceCourse.TabIndex = 10;
            this.chkIsServiceCourse.UseVisualStyleBackColor = true;
            this.chkIsServiceCourse.CheckedChanged += new System.EventHandler(this.chkIsServiceCourse_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Availability:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboAvailablity
            // 
            this.cboAvailablity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailablity.FormattingEnabled = true;
            this.cboAvailablity.Items.AddRange(new object[] {
            "Every Semester",
            "1st Semester Only",
            "2nd Semester Only"});
            this.cboAvailablity.Location = new System.Drawing.Point(127, 142);
            this.cboAvailablity.Name = "cboAvailablity";
            this.cboAvailablity.Size = new System.Drawing.Size(121, 21);
            this.cboAvailablity.TabIndex = 8;
            this.cboAvailablity.SelectedIndexChanged += new System.EventHandler(this.cboAvailablity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Laboratory:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkLaboratory
            // 
            this.chkLaboratory.AutoSize = true;
            this.chkLaboratory.Location = new System.Drawing.Point(127, 122);
            this.chkLaboratory.Name = "chkLaboratory";
            this.chkLaboratory.Size = new System.Drawing.Size(15, 14);
            this.chkLaboratory.TabIndex = 6;
            this.chkLaboratory.UseVisualStyleBackColor = true;
            this.chkLaboratory.CheckedChanged += new System.EventHandler(this.chkLaboratory_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Units:";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(127, 71);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(87, 20);
            this.txtUnits.TabIndex = 4;
            this.txtUnits.Text = "3.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(127, 45);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Code :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hours Per Week:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(126, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // FrmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSubjects);
            this.Name = "FrmSubjects";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.FrmSubjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSubjects;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colUnits;
        private System.Windows.Forms.ColumnHeader colIsLaboratory;
        private System.Windows.Forms.ColumnHeader colClassification;
        private System.Windows.Forms.ColumnHeader colAvailability;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLaboratory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAvailablity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsServiceCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}