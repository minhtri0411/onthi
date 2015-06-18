using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory
{
    public class SlowPC : PC
    {
        public SlowPC()
        {
            this.Ram = this.RamFactory.CreateRam(RAMFactory.SLOW_RAM);
            this.Cpu = this.CpuFactory.CreateCPU(CPUFactory.SLOW_CPU);
            this.Hdd = this.HddFactory.CreateHDD(HDDFactory.SLOW_HDD);
        }

        public override string GetPCInfo()
        {

           return "Slow Pc: " + base.GetPCInfo();
        }
    }
}
