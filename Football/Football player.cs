using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Football_player : Person
    {
        public int Number { get; set; }
        public int Height { get; set; }
        protected Football_player(string name, int age, int number, int height) : base(name, age)
        {
            Number = number;
            Height = height;
        }  

    }
}
