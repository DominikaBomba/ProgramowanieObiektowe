using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05.classes
{
    internal class MachineTypeManeger
    {
        private List<string> machineType = new List<string>();

        public MachineTypeManeger() {
            machineType.Add("Koparka");
            machineType.Add("Dźwig");
            machineType.Add("Spychacz");
            machineType.Add("Ładowarka");
        
        }
        public void AddMachineType(string type)
        {
            if(!machineType.Contains(type))
            {
                machineType.Add(type);
                Console.WriteLine($"Typ maszyny {type} został dodany");
            }
            else
            {
                Console.WriteLine($"Typ maszyny {type} już istnieje");
            }
        }
        public void DisplayMachineType()
        {
            foreach (string maszyny in machineType)
            {
             
              Console.Write($"{machineType}, ");
            }
        }
        public bool IsValidType(string type)
        {
            return machineType.Contains(type);
        }


    }
}
