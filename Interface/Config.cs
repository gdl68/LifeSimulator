using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Config
    {
        public string Name;
        public int Age;
        public string Gender;

        public Config(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }
    }
}
