using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------------
namespace BackUp
{
    class HDD : Storage
    {
        double speed; 
        int countOfSection;
        double capacityOfSection;

        public HDD(int countOfSection, double capacityOfSection, string name, string model) : base(name, model)
        {
            speed = 120;
            this.countOfSection = countOfSection;
            this.capacityOfSection = capacityOfSection;
        }

        public override double GetCapacity() { return (countOfSection * capacityOfSection); }
        public override double GetSpeed() {  return speed; }
        public override int GetTime()
        {
            double doubleTemp = (countOfSection * capacityOfSection) / speed;
            int temp = Convert.ToInt32(Math.Round(doubleTemp));
            return temp;
        }
    }
}
//-----------------------------------------------------------------------------------