using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitTest
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Students() { }

        public Students(int id, string name, int age)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
        }
    }
}
