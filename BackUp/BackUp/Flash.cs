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
                speed = 480;
            else
            if (type == '3')
                speed = 5000;

            this.capacity = capacity * 1000;
        }

        public override double GetSpeed() { return speed; } 
        public override double GetCapacity() { return capacity; }
        public override int GetTime()
        {
            double doubleTemp = capacity / speed;
            int temp = Convert.ToInt32(Math.Round(doubleTemp));
            return temp;
        }
    }
}
//-----------------------------------------------------------------------------------