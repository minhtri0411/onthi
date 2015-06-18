using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory
{
    public class HighPC : PC
    {
        public HighPC()
        {
            this.Ram = this.RamFactory.CreateRam(RAMFactory.HIGH_RAM);
            this.Cpu = this.CpuFactory.CreateCPU(CPUFactory.HIGH_CPU);
            this.Hdd = this.HddFactory.CreateHDD(HDDFactory.HIGH_HDD);
        }
        public string GetPCName()
        {
            return "High PC";
        }
        public override string GetPCInfo()
        {
            return "High Pc: " + base.GetPCInfo();
        }
    }
}
