using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------------
namespace BackUp
{
    class Flash : Storage
    {
        double speed;
        double capacity;

        public Flash(char type, double capacity, string name, string model) : base(name, model)
        {
            if (type == '2')
                speed = 0.48;
            else
            if (type == '3')
                speed = 5;

            this.capacity = capacity;
        }

        public double Speed { get { return speed; } }

        public override double GetCapacity() { return capacity; }
    }
}
//-----------------------------------------------------------------------------------