using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_rabbit_explosion
{
    class Rabbit
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Rabbit(int counter)
        {
            this.Age = 0;
            this.Name = "Rabbit" + counter;
        }
    }
}
