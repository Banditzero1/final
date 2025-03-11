using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Student1 : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }
        public double Grade { get; set; }
        public string Advisor { get; set; }

        public override string GetDetails()
        {
            return $"ID: {StudentID}, Name: {Name}, Major: {Major}, Grade: {Grade}, Advisor: {Advisor}";
        }
    }
}
