using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------------
namespace BackUp
{
    class DVD : Storage
    {
        double ReadSpeed;
        double WriteSpeed;
        double capacity;

        public DVD(double ReadSpeed, double WriteSpeed, char type, string name, string model) : base(name, model)
        {
            this.ReadSpeed = ReadSpeed;
            this.WriteSpeed = WriteSpeed;

            if (type == 'o')
                capacity = 4.7;
            else
            if (type == 't')
                capacity = 9;
        }

        public override double GetCapacity() { return capacity; }
    }
}
//-----------------------------------------------------------------------------------