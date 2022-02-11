using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeefvanEratosthenes
{
    public class Priemgetallen
    {
        public List<int> Zoek(int maximum)
        {
            var getallen = new List<int>();
            var output = new List<int>();
            for (int i = 2; i <= maximum; i++)
            {
                getallen.Add(i);
            }
            while (getallen.Any())
            {
                var kleinsteGetal = getallen.OrderBy(x => x).FirstOrDefault();
                output.Add(kleinsteGetal);
                for (int i = 1; i <= maximum; i++)
                {
                    var veelvouden = kleinsteGetal * i;
                    getallen.Remove(veelvouden);
                }
            }

            return output;
        }
    }
}
