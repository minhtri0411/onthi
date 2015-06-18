using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class SlowHDD : HDD
    {
        public SlowHDD()
        {
            this.HDDSpeed = "Read: 250Mbs/s; Write: 125Mbs/s";
            this.HDDVolume = "0.25 Ytb";
        }

        public override string GetName()
        {
            return "Slow hdd";
        }
    }
}
