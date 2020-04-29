using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    class EmailValidator: IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if (candidate.Contains("@"))
            {
                if (candidate.EndsWith(".com"))
                 return true; 
                else if (candidate.EndsWith(".hr"))
                 return true;                
            }
            return false;
        }
    }
}
