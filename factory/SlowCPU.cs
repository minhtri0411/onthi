using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class SlowCPU : CPU
    {
        public SlowCPU()
        {
            this.CPUSpeed = "1700 Ghz";
            this.Type = "i3";
        }

        public override string GetName()
        {
            return "Slow cpu";
        }
    }
}
