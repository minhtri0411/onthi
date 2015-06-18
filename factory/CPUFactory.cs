using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class CPUFactory
    {
        public const string HIGH_CPU = "HIGH_CPU";
        public const string MEDIUM_CPU = "MEDIUM_CPU";
        public const string SLOW_CPU = "SLOW_CPU";

        public CPU CreateCPU(string tenCPU)
        {
            switch (tenCPU)
            {
                case CPUFactory.HIGH_CPU:
                    return new HighCPU(); break;
                case CPUFactory.MEDIUM_CPU:
                    return new MediumCPU(); break;
                case CPUFactory.SLOW_CPU:
                    return new SlowCPU(); break;
                default: return null;
            }
        }
    }
}
