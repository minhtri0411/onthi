using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
   public class HDD
    {
        public string HDDVolume { get; set; }
        public string HDDSpeed { get; set; }

        public virtual string GetName()
        {
            return null;
        }      
    }
}
