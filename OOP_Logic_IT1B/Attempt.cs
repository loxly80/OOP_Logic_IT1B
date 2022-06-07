using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Logic_IT1B
{
    public class Attempt
    {
        public Pin[] Pins { get; internal set; }

        public Attempt()
        {
            Pins = new Pin[4];
        }

        public List<bool> Evaluate(Pin[] pattern)
        {
            List<bool> result = new List<bool>();
            bool[] flag = new bool[4];
            
            for(int i = 0; i < pattern.Length; i++)
            {
                if(pattern[i] == Pins[i])
                {
                    flag[i] = false;
                    result.Add(true);
                }
            }

            for(int i = 0; i < pattern.Length; i++)
            {

            }
            
            return new List<bool>();
        }
    }
}
