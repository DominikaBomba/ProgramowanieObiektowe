using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05.classes
{
    internal class Loader : Machine
    {
        public Loader(string name) : base(name) 
        {
        


        }
        ~Loader() {
            Console.WriteLine($"Ładowarka {Name} została zniszczona" );

        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna ładowanie materiałów");
        }
        public void Load()
        {
            Console.WriteLine($"{Name} ładuje materiały");
        }
        public override void Work()
        {
            Load();
        }

    }
}
