namespace Quiz
{
    partial class from1
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
            btnAddStudent = new Button();
            la1 = new Label();
            txtStudentID = new TextBox();
            la2 = new Label();
            la3 = new Label();
            label1 = new Label();
            btnShowAllStudents = new Button();
            btnShowAdvisorStudents = new Button();
            btnShowTopStudent = new Button();
            txtName = new TextBox();
            txtMajor = new TextBox();
            txtGrade = new TextBox();
            cmbAdvisor = new ComboBox();
            lstDisplay = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(383, 94);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(216, 29);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // la1
            // 
            la1.AutoSize = true;
            la1.Location = new Point(38, 153);
            la1.Name = "la1";
            la1.Size = new Size(79, 20);
            la1.TabIndex = 1;
            la1.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(155, 150);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 2;
            // 
            // la2
            // 
            la2.AutoSize = true;
            la2.Location = new Point(39, 209);
            la2.Name = "la2";
            la2.Size = new Size(49, 20);
            la2.TabIndex = 3;
            la2.Text = "Name";
            // 
            // la3
            // 
            la3.AutoSize = true;
            la3.Location = new Point(39, 273);
            la3.Name = "la3";
            la3.Size = new Size(48, 20);
            la3.TabIndex = 4;
            la3.Text = "Major";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 326);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Grade";
            // 
            // btnShowAllStudents
            // 
            btnShowAllStudents.Location = new Point(383, 209);
            btnShowAllStudents.Name = "btnShowAllStudents";
            btnShowAllStudents.Size = new Size(209, 29);
            btnShowAllStudents.TabIndex = 6;
            btnShowAllStudents.Text = "Show All Students";
            btnShowAllStudents.UseVisualStyleBackColor = true;
            btnShowAllStudents.Click += btnShowAllStudents_Click;
            // 
            // btnShowAdvisorStudents
            // 
            btnShowAdvisorStudents.Location = new Point(383, 144);
            btnShowAdvisorStudents.Name = "btnShowAdvisorStudents";
            btnShowAdvisorStudents.Size = new Size(237, 29);
            btnShowAdvisorStudents.TabIndex = 7;
            btnShowAdvisorStudents.Text = "Show Advisor's Students";
            btnShowAdvisorStudents.UseVisualStyleBackColor = true;
            btnShowAdvisorStudents.Click += btnShowAdvisorStudents_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(383, 273);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(266, 29);
            btnShowTopStudent.TabIndex = 8;
            btnShowTopStudent.Text = "Show Top Student\r\n";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            btnShowTopStudent.Click += btnShowTopStudent_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(155, 273);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(125, 27);
            txtMajor.TabIndex = 11;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(155, 326);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 12;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(726, 95);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(151, 28);
            cmbAdvisor.TabIndex = 14;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(397, 309);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(467, 164);
            lstDisplay.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 16;
            label2.Text = "Advisor";
            label2.Click += label2_Click;
            // 
            // from1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 505);
            Controls.Add(label2);
            Controls.Add(lstDisplay);
            Controls.Add(cmbAdvisor);
            Controls.Add(txtGrade);
            Controls.Add(txtMajor);
            Controls.Add(txtName);
            Controls.Add(btnShowTopStudent);
            Controls.Add(btnShowAdvisorStudents);
            Controls.Add(btnShowAllStudents);
            Controls.Add(label1);
            Controls.Add(la3);
            Controls.Add(la2);
            Controls.Add(txtStudentID);
            Controls.Add(la1);
            Controls.Add(btnAddStudent);
            Name = "from1";
            Text = "Form1";
            Load += btnShowTopStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Label la1;
        private TextBox txtStudentID;
        private Label la2;
        private Label la3;
        private Label label1;
        private Button btnShowAllStudents;
        private Button btnShowAdvisorStudents;
        private Button btnShowTopStudent;
        private TextBox txtName;
        private TextBox txtMajor;
        private TextBox txtGrade;
        private ComboBox cmbAdvisor;
        private ListBox lstDisplay;
        private Label label2;
    }
}
