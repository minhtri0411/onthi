using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class CPU
    {
        public string CPUSpeed { get; set; }
        public string Type { get; set; }

        public virtual string GetName()
        {
            return null;
        }
    }
}
