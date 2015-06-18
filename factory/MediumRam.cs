using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class MediumRam : Ram
    {
        public MediumRam()
        {
            this.Bus = "2500 Mhz";
            this.Volume = "4Gb";
        }

        public override string GetName()
        {
            return "Medium ram";
        }
    }
}
