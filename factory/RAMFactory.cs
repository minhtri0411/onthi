using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class RAMFactory
    {
        public const string HIGH_RAM = "HIGH_RAM";
        public const string MEDIUM_RAM = "MEDIUM_RAM";
        public const string SLOW_RAM = "SLOW_RAM";

        public Ram CreateRam(string tenRAM)
        {
            switch (tenRAM)
            {
                case RAMFactory.HIGH_RAM:
                    return new HighRam(); break;
                case RAMFactory.MEDIUM_RAM:
                    return new MediumRam(); break;
                case RAMFactory.SLOW_RAM:
                    return new SlowRam(); break;
                default: return null;
            }
        }
    }
}
