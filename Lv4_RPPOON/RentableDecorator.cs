using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    abstract class RentableDecorator : IRentable
    {
        private IRentable rentable;
        public RentableDecorator(IRentable rentable)
        {
            this.rentable = rentable;
        }
        public virtual double CalculatePrice()
        {
            return rentable.CalculatePrice();
        }
        public virtual String Description
        {
            get
            {
                return rentable.Description;
            }
        }
    }
}
