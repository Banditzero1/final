using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Person
    {
        public string Name { get; set; }

        public virtual string GetDetails()
        {
            return $"Name: {Name}";
        }
    }
}
