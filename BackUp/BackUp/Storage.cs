using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------------
namespace BackUp
{
    abstract class Storage
    {
        protected string name;
        protected string model;

        protected Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

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

        public abstract double GetCapacity();

        //public abstract void Copy(); 

        //public abstract void GetFreeSize();

        //public abstract void GetInformation();
    }
}
//-----------------------------------------------------------------------------------