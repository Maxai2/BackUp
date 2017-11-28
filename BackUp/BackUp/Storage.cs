using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp
{
    abstract class Storage
    {
        string name;
        string model;
        double capacity;

        string Name
        {
            get { return name; }
            set { name = value; }
        }

        string Model
        {
            get { return model; }
            set { model = value; }
        }

        bool Copy()
        {

        }

        double Capacity
        {
            get { return capacity; }
            set
            {
                if (value >= 0)
                capacity = value;
            }
        }

        string[] Information()
        {
            string[] temp = new string[3];

            temp[0] = name;
            temp[1] = model;
            temp[2] = capacity.ToString();

            return temp;
        }
    }
}
