using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class HighCPU : CPU
    {
        public HighCPU()
        {
            this.CPUSpeed = "3500 Ghz";
            this.Type = "i9";
        }

        public override string GetName()
        {
            return "High cpu";
        }
    }
}
