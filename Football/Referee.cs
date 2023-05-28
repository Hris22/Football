using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Referee : Person
    {
        public string Role { get; set; }
        public Referee(string name, int age, string role) : base(name, age)
        {
            Role = role;
        }
    }
}
