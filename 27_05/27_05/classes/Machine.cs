using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05.classes
{
    internal class Machine
    {
        public string Name { get; set; }
        public bool IsOperational { get; private set; } = true;
        public string FailureMode { get; private set; }
        public Machine(string name) {
            Name = name;
        }
        public virtual void Start()
        {
            Console.WriteLine($"{Name} rozpoczony pracę");
        }
        public virtual void Stop() {
            Console.WriteLine($"{Name} kończy pracę");

        }
        public virtual void Work()
        {
            Console.WriteLine($"{Name} praceuje");
        }
        public void SimulateFailure(string failureMode)
        {
            IsOperational = false;
            FailureMode = failureMode;
            Console.WriteLine($"{Name} ulegl awarii: {failureMode}");

        }
        public void Repair()
        {
            IsOperational = true;
            FailureMode = null;
            Console.WriteLine($"{Name} została naprawiona i jest ponownie sprawna");

        }
        public void DisplayStatus()
        {
            var status = IsOperational ? "sprawna" :  $"niesprawna {FailureMode}";
            Console.WriteLine($"{Name} jest obecnie {status}");
        }

    }
}
