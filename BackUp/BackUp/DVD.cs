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

        public DVD(char type, string name, string model) : base(name, model)
        { 
			WriteSpeed = 9.8;

			if (type == 'o')
			{
				capacity = 4.7;
				ReadSpeed = 11.08;
			}
			else
			if (type == 't')
			{ 
                capacity = 9;
				ReadSpeed = 10.08;
			}
        }

        public override double GetCapacity() { return capacity; }
    }
}
//-----------------------------------------------------------------------------------