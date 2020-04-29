using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
