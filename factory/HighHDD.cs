using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class HighHDD : HDD
    {
        public HighHDD()
        {
            this.HDDSpeed = "Read: 1000Mbs/s; Write: 500Mbs/s";
            this.HDDVolume = "1 Ytb";
        }

        public override string GetName()
        {
            return "High hdd";
        }

    }
}
