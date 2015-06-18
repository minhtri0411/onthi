using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factory
{
    public class MediumPC : PC
    {
        public MediumPC()
        {
            this.Ram = this.RamFactory.CreateRam(RAMFactory.MEDIUM_RAM);
            this.Cpu = this.CpuFactory.CreateCPU(CPUFactory.MEDIUM_CPU);
            this.Hdd = this.HddFactory.CreateHDD(HDDFactory.MEDIUM_HDD);
        }
        public string GetPCName()
        {
            return "Medium PC";
        }

        public override string GetPCInfo()
        {
            return "Medium Pc: " + base.GetPCInfo();
        }
    }
}
