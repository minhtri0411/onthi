using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory
{
    public class Ram
    {
        public string Bus { get; set; }
        public string Volume { get; set; }

        public virtual string GetName()
        {
            return null;
        }
    }
}
