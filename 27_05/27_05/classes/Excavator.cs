using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05.classes
{
    internal class Excavator : Machine
    {
        public int DigDepth { get; set; }
        public Excavator(string name, int digdepth) : base(name)
        {
            DigDepth = digdepth;
        }
        public override void Start()
        {
            Console.WriteLine($"{Name} ropoczyna kopanie");
     
        }
        public override void Stop()
        {
            Console.WriteLine($"{Nam} kończy prace");
        }
    }
}
