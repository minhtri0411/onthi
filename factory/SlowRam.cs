using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class SlowRam : Ram
    {
        public SlowRam()
        {
            this.Bus = "1000 Mhz";
            this.Volume = "128 Mb";
        }

        public override string GetName()
        {
            return "Slow ram";
        }
    }
}
