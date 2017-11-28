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

        public HDD(double speed, int countOfSection, double capacityOfSection, string name, string model) : base(name, model)
        {
            this.speed = speed;
            this.countOfSection = countOfSection;
            this.capacityOfSection = capacityOfSection;
        }

        public override double GetCapacity() { return (countOfSection * capacityOfSection); }
    }
}
//-----------------------------------------------------------------------------------