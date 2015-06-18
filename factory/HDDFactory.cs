using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class HDDFactory
    {
        public const string HIGH_HDD = "HIGH_HDD";
        public const string MEDIUM_HDD = "MEDIUM_HDD";
        public const string SLOW_HDD = "SLOW_HDD";

        public HDD CreateHDD(string tenHDD)
        {
            switch (tenHDD)
            {
                case HDDFactory.HIGH_HDD:
                    return new HighHDD(); break;
                case HDDFactory.MEDIUM_HDD:
                    return new MediumHDD(); break;
                case HDDFactory.SLOW_HDD:
                    return new SlowHDD(); break;
                default: return null;
            }
        }
    }
}
