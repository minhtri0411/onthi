using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class PC
    {
        public const string HIGH_PC = "HIGH_PC";
        public const string MEDIUM_PC = "MEDIUM_PC";
        public const string SLOW_PC = "SLOW_PC";

        public RAMFactory RamFactory;
        public CPUFactory CpuFactory;
        public HDDFactory HddFactory;

        public Ram Ram { get; set; }
        public CPU Cpu { get; set; }
        public HDD Hdd { get; set; }

        public PC()
        {
            this.RamFactory = new RAMFactory();
            this.HddFactory = new HDDFactory();
            this.CpuFactory = new CPUFactory();
        }

        public static PC CreatePC(string pcName)
        {
            switch (pcName)
            {
                case PC.HIGH_PC :
                    return new HighPC();
                case PC.MEDIUM_PC:
                    return new MediumPC();
                case PC.SLOW_PC:
                    return new SlowPC();
                default: return null;
            }
        }

        public virtual string GetPCInfo()
        {
            string info = this.Ram.GetName() + "\n" + this.Hdd.GetName() + "\n" + this.Cpu.GetName();
            return info;
        }
    }
}
