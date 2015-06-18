using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class MediumCPU : CPU
    {
        public MediumCPU()
        {
            this.CPUSpeed = "2500 Ghz";
            this.Type = "i7";
        }

        public override string GetName()
        {
            return "Medium cpu";
        }
    }
}
