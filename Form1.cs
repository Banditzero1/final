using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Quiz
{
    public partial class from1 : Form
    {
        List<Student> students = new List<Student>();
        List<string> advisors = new List<string>() { "Dr. Smith", "Prof. Brown", "Ms. Green" };
        public from1()
        {
            InitializeComponent();
            cmbAdvisor.DataSource = advisors;
        }

        private void btnShowTopStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtMajor.Text) ||
                string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!double.TryParse(txtGrade.Text, out double grade) || grade < 0 || grade > 4)
            {
                MessageBox.Show("Please enter a valid grade (0.0 - 4.0).");
                return;
            }

            // สร้างอ็อบเจ็กต์นักศึกษาและเพิ่มในรายการ
            Student student = new Student()
            {
                StudentID = txtStudentID.Text,
                Name = txtName.Text,
                Major = txtMajor.Text,
                Grade = grade,
                Advisor = cmbAdvisor.SelectedItem.ToString()
            };
            students.Add(student);

            // Clear fields after adding
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtMajor.Clear();
            txtGrade.Clear();
            cmbAdvisor.SelectedIndex = 0;
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            foreach (var student in students)
            {
                lstDisplay.Items.Add(student.ToString());
            }
        }

        private void btnShowAdvisorStudents_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            string selectedAdvisor = cmbAdvisor.SelectedItem.ToString();
            foreach (var student in students)
            {
                if (student.Advisor == selectedAdvisor)
                {
                    lstDisplay.Items.Add(student.ToString());
                }
            }
        }

        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available.");
                return;
            }

            var topStudent = students[0];
            foreach (var student in students)
            {
                if (student.Grade > topStudent.Grade)
                {
                    topStudent = student;
                }
            }

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Top Student:");
            lstDisplay.Items.Add(topStudent.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public double Grade { get; set; }
        public string Advisor { get; set; }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Major: {Major}, Grade: {Grade}, Advisor: {Advisor}";
        }
    }
}
    




        
    
    
    
    

