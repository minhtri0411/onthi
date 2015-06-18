using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class HighRam : Ram
    {
        public HighRam()
        {
            this.Bus = "3500 Mhz";
            this.Volume = "8Gb";
        }

        public override string GetName()
        {
            return "High ram";
        }
    }
}
