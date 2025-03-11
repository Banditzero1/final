@ -0,0 +1,194 @@
Class diagram ของโปรแกรมที่ตนเองออกแบบ (เขียนให้ถูกต้องและครบถ้วน)
using System; // นำเข้า namespace System เพื่อใช้คลาสพื้นฐาน เช่น EventArgs
using System.Collections.Generic; // นำเข้า namespace System.Collections.Generic เพื่อใช้ List
using System.Windows.Forms; // นำเข้า namespace System.Windows.Forms เพื่อใช้คลาสที่เกี่ยวข้องกับ Windows Forms

namespace Quiz // กำหนด namespace ชื่อ Quiz เพื่อจัดกลุ่มคลาสที่เกี่ยวข้องกับโปรแกรม Quiz
{
    public partial class from1 : Form // ประกาศคลาสชื่อ from1 ที่สืบทอดมาจากคลาส Form (Windows Form) และเป็น partial class (โค้ดอาจถูกแบ่งไว้ในไฟล์อื่นด้วย)
    {
        List<Student> students = new List<Student>(); // สร้าง List ชื่อ students เพื่อเก็บอ็อบเจ็กต์ Student
        List<string> advisors = new List<string>() { "Dr. Smith", "Prof. Brown", "Ms. Green" }; // สร้าง List ชื่อ advisors เพื่อเก็บรายชื่ออาจารย์ที่ปรึกษา
        public from1() // Constructor ของคลาส from1
        {
            InitializeComponent(); // เรียกเมธอด InitializeComponent() ที่สร้างและเริ่มต้น components ของฟอร์ม (เช่น TextBoxes, Buttons, ListBox)
            cmbAdvisor.DataSource = advisors; // กำหนด DataSource ของ ComboBox ชื่อ cmbAdvisor ให้เป็น List ของ advisors เพื่อให้แสดงรายชื่ออาจารย์ที่ปรึกษา
        }

        private void btnShowTopStudent_Load(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Load ของปุ่ม btnShowTopStudent (แต่ไม่มีโค้ดภายใน)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Click ของปุ่ม btnAddStudent
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || // ตรวจสอบว่า TextBox txtStudentID ว่างเปล่าหรือไม่
                string.IsNullOrWhiteSpace(txtName.Text) || // ตรวจสอบว่า TextBox txtName ว่างเปล่าหรือไม่
                string.IsNullOrWhiteSpace(txtMajor.Text) || // ตรวจสอบว่า TextBox txtMajor ว่างเปล่าหรือไม่
                string.IsNullOrWhiteSpace(txtGrade.Text)) // ตรวจสอบว่า TextBox txtGrade ว่างเปล่าหรือไม่
            {
                MessageBox.Show("Please fill in all fields."); // แสดงข้อความแจ้งเตือนให้กรอกข้อมูลให้ครบ
                return; // ออกจากเมธอด (ไม่ต้องทำอะไรต่อ)
            }

            if (!double.TryParse(txtGrade.Text, out double grade) || grade < 0 || grade > 4) // ตรวจสอบว่าค่าใน txtGrade สามารถแปลงเป็น double ได้หรือไม่ และอยู่ในช่วง 0.0 ถึง 4.0 หรือไม่
            {
                MessageBox.Show("Please enter a valid grade (0.0 - 4.0)."); // แสดงข้อความแจ้งเตือนให้ป้อนเกรดที่ถูกต้อง
                return; // ออกจากเมธอด (ไม่ต้องทำอะไรต่อ)
            }

            // สร้างอ็อบเจ็กต์นักศึกษาและเพิ่มในรายการ
            Student student = new Student() // สร้างอ็อบเจ็กต์ Student ใหม่
            {
                StudentID = txtStudentID.Text, // กำหนด StudentID จาก TextBox txtStudentID
                Name = txtName.Text, // กำหนด Name จาก TextBox txtName
                Major = txtMajor.Text, // กำหนด Major จาก TextBox txtMajor
                Grade = grade, // กำหนด Grade จากตัวแปร grade (ที่แปลงมาจาก txtGrade)
                Advisor = cmbAdvisor.SelectedItem.ToString() // กำหนด Advisor จากรายการที่เลือกใน ComboBox cmbAdvisor
            };
            students.Add(student); // เพิ่มอ็อบเจ็กต์ Student ลงใน List students

            // Clear fields after adding
            ClearInputFields(); // เรียกเมธอด ClearInputFields() เพื่อล้างข้อมูลในช่องป้อนข้อมูล
        }
        private void ClearInputFields() // เมธอด ClearInputFields() สำหรับล้างข้อมูลในช่องป้อนข้อมูล
        {
            txtStudentID.Clear(); // ล้างข้อความใน TextBox txtStudentID
            txtName.Clear(); // ล้างข้อความใน TextBox txtName
            txtMajor.Clear(); // ล้างข้อความใน TextBox txtMajor
            txtGrade.Clear(); // ล้างข้อความใน TextBox txtGrade
            cmbAdvisor.SelectedIndex = 0; // เลือกรายการแรกใน ComboBox cmbAdvisor (เป็นการ reset ค่า)
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Click ของปุ่ม btnShowAllStudents
        {
            lstDisplay.Items.Clear(); // ล้างรายการทั้งหมดใน ListBox lstDisplay
            foreach (var student in students) // วนลูปผ่านอ็อบเจ็กต์ Student แต่ละตัวใน List students
            {
                lstDisplay.Items.Add(student.ToString()); // เพิ่ม string representation ของ Student ลงใน ListBox lstDisplay (โดยใช้เมธอด ToString() ของคลาส Student)
            }
        }

        private void btnShowAdvisorStudents_Click(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Click ของปุ่ม btnShowAdvisorStudents
        {
            lstDisplay.Items.Clear(); // ล้างรายการทั้งหมดใน ListBox lstDisplay
            string selectedAdvisor = cmbAdvisor.SelectedItem.ToString(); // ดึงรายชื่ออาจารย์ที่ปรึกษาที่เลือกจาก ComboBox cmbAdvisor
            foreach (var student in students) // วนลูปผ่านอ็อบเจ็กต์ Student แต่ละตัวใน List students
            {
                if (student.Advisor == selectedAdvisor) // ตรวจสอบว่า Advisor ของ Student ตรงกับ Advisor ที่เลือกหรือไม่
                {
                    lstDisplay.Items.Add(student.ToString()); // เพิ่ม string representation ของ Student ลงใน ListBox lstDisplay
                }
            }
        }

        private void btnShowTopStudent_Click(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Click ของปุ่ม btnShowTopStudent
        {
            if (students.Count == 0) // ตรวจสอบว่า List students ว่างเปล่าหรือไม่
            {
                MessageBox.Show("No students available."); // แสดงข้อความแจ้งเตือนว่าไม่มีนักศึกษาในระบบ
                return; // ออกจากเมธอด (ไม่ต้องทำอะไรต่อ)
            }

            var topStudent = students[0]; // กำหนดให้นักศึกษาคนแรกใน List เป็นนักศึกษาที่เกรดสูงสุดเริ่มต้น
            foreach (var student in students) // วนลูปผ่านอ็อบเจ็กต์ Student แต่ละตัวใน List students
            {
                if (student.Grade > topStudent.Grade) // ตรวจสอบว่า Grade ของ Student ปัจจุบันสูงกว่า Grade ของ topStudent หรือไม่
                {
                    topStudent = student; // ถ้า Grade สูงกว่า ให้กำหนด Student ปัจจุบันเป็น topStudent
                }
            }

            lstDisplay.Items.Clear(); // ล้างรายการทั้งหมดใน ListBox lstDisplay
            lstDisplay.Items.Add("Top Student:"); // เพิ่มข้อความ "Top Student:" ลงใน ListBox lstDisplay
            lstDisplay.Items.Add(topStudent.ToString()); // เพิ่ม string representation ของ topStudent ลงใน ListBox lstDisplay
        }

        private void label2_Click(object sender, EventArgs e) // Event handler สำหรับเหตุการณ์ Click ของ Label label2 (แต่ไม่มีโค้ดภายใน)
        {

        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Person
    {
        // Property Name: เก็บชื่อของบุคคล
        public string Name { get; set; }

        // Method GetDetails: คืนค่ารายละเอียดของบุคคลในรูปแบบสตริง
        // 'virtual' keyword: อนุญาตให้คลาสที่สืบทอดสามารถ override เมธอดนี้ได้
        public virtual string GetDetails()
        {
            // ใช้ string interpolation เพื่อสร้างสตริง
            return $"Name: {Name}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    // คลาส Student1 สืบทอดมาจากคลาส Person
    public class Student1 : Person
    {
        // Property StudentID: รหัสนักศึกษา
        public string StudentID { get; set; }

        // Property Major: สาขาวิชาเอก
        public string Major { get; set; }

        // Property Grade: เกรดเฉลี่ย
        public double Grade { get; set; }

        // Property Advisor: อาจารย์ที่ปรึกษา
        public string Advisor { get; set; }

        // Override Method GetDetails:  ปรับแต่งการแสดงรายละเอียดของนักศึกษา
        // 'override' keyword:  ระบุว่าเมธอดนี้เป็นการ override เมธอด virtual จากคลาส Person
        public override string GetDetails()
        {
            // ใช้ string interpolation เพื่อสร้างสตริงที่แสดงรายละเอียดของนักศึกษา
            // โดยรวมถึง ID, ชื่อ, สาขาวิชา, เกรด, และอาจารย์ที่ปรึกษา
            return $"ID: {StudentID}, Name: {Name}, Major: {Major}, Grade: {Grade}, Advisor: {Advisor}";

        }
    }
}
โปรแกรมได้ใช้หลักการเขียนโปรแกรมตามหลักการเขียนโปรแกรมเชิงวัตถุอย่างไรบ้าง
Abstraction (นามธรรม):

Class Student1: แทนแนวคิดของนักเรียนในโลกแห่งความเป็นจริง โดยซ่อนรายละเอียดที่ไม่จำเป็น (เช่น วิธีการเก็บข้อมูล) และแสดงเฉพาะสิ่งที่สำคัญ (ID, ชื่อ, สาขา, เกรด, อาจารย์ที่ปรึกษา) ผู้ใช้ Class ไม่จำเป็นต้องรู้ว่าข้อมูลเหล่านี้ถูกเก็บอย่างไร เพียงแค่รู้ว่าจะเข้าถึงและใช้งานมันได้อย่างไร
Encapsulation (การห่อหุ้ม):

Class Student1: Attributes (Properties) ของนักเรียน (เช่น ID, Name) ถูกกำหนดให้เป็น public, ซึ่งหมายความว่าสามารถเข้าถึงและแก้ไขได้จากภายนอก Class โดยตรง. แม้ว่าในกรณีนี้จะไม่ได้มีการ Encapsulate อย่างเข้มงวด (เช่น การใช้ private และ public methods ในการเข้าถึงข้อมูล) แต่ก็ยังมีการจัดกลุ่มข้อมูลที่เกี่ยวข้องไว้ด้วยกันใน Class เดียว
Form ต่างๆ: Form แต่ละ Form (เช่น Form1, AddEditStudentForm) ห่อหุ้ม Logic ที่เกี่ยวข้องกับการแสดงผลและการจัดการข้อมูลใน Form นั้นๆ
Inheritance (การสืบทอด):

โปรแกรมนี้ไม่ได้ใช้ Inheritance โดยตรง แต่ Windows Forms เองใช้ Inheritance อย่างมาก ตัวอย่างเช่น Form1 สืบทอดมาจาก Class Form ซึ่งเป็น Class พื้นฐานสำหรับ Windows Forms ทั้งหมด Form1 จึงได้รับคุณสมบัติและวิธีการต่างๆ จาก Form และสามารถเพิ่มหรือปรับเปลี่ยนการทำงานได้
Polymorphism (พหุสัณฐาน):

โปรแกรมนี้ไม่ได้ใช้ Polymorphism โดยตรง แต่ Windows Forms มีการใช้ Polymorphism ในระดับหนึ่ง ตัวอย่างเช่น Event Handler (addButton_Click, dataGridView1_CellClick) เป็น Delegate ที่สามารถชี้ไปยัง Method ใดก็ได้ที่มี Signature ที่ถูกต้อง ทำให้สามารถตอบสนองต่อ Event ต่างๆ ได้อย่างยืดหยุ่น
สรุปการใช้ OOP ในโปรแกรม

Object Creation: มีการสร้าง Object จาก Class Student1 เพื่อเก็บข้อมูลนักเรียนแต่ละคน
Data Structures: มีการใช้ List<Student1> ซึ่งเป็น Collection ของ Object Student1 เพื่อจัดการข้อมูลนักเรียนจำนวนมาก
Event Handling: ใช้ Event Handling ของ Windows Forms ซึ่งเป็นกลไกที่ขับเคลื่อนด้วย Object และ Event
สิ่งที่สามารถปรับปรุงได้เพื่อเพิ่มการใช้ OOP

Encapsulation: ทำให้ Properties ใน Class Student1 เป็น private และสร้าง public Methods (Getters/Setters) เพื่อควบคุมการเข้าถึงข้อมูล
Inheritance: ถ้ามี Class นักเรียนหลายประเภท (เช่น นักเรียนปริญญาตรี, นักเรียนปริญญาโท) สามารถสร้าง Class ลูกที่สืบทอดจาก Class Student1 และเพิ่ม Properties/Methods ที่เฉพาะเจาะจงได้
Polymorphism: ถ้ามีการคำนวณเกรดที่แตกต่างกันสำหรับนักเรียนแต่ละประเภท สามารถใช้ Interface หรือ Abstract Class เพื่อกำหนด Method CalculateGrade() และให้ Class ลูกแต่ละ Class Implement วิธีการคำนวณของตนเอง
Dependency Injection: ใช้ Dependency Injection เพื่อลดการพึ่งพากันระหว่าง Class และทำให้โค้ดง่ายต่อการ Test
