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
        //double ReadSpeed;
        double WriteSpeed;
        double capacity;

        public DVD(char type, string name, string model) : base(name, model)
        { 
			WriteSpeed = 980;

			if (type == 'o')
			//{
				capacity = 4700;
				//ReadSpeed = 11.08;
			//}
			else
			if (type == 't')
			//{ 
                capacity = 9000;
				//ReadSpeed = 10.08;
			//}
        }

        public override double GetCapacity() { return capacity; }
        public override double GetSpeed() { return WriteSpeed; }
        public override int GetTime()
        {
            double doubleTemp = capacity / WriteSpeed;
            int temp = Convert.ToInt32(Math.Round(doubleTemp));
            return temp;
        }
    }
}
//-----------------------------------------------------------------------------------