using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class MediumHDD : HDD
    {
        public MediumHDD()
        {
            this.HDDSpeed = "Read: 500Mbs/s; Write: 250Mbs/s";
            this.HDDVolume = "0.5 Ytb";
        }

        public override string GetName()
        {
            return "Medium hdd";
        }
    }
}
