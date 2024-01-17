using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Helicopter : Air
    {
        public int Blades { get; set; }

        public Helicopter(string make, string model, int year, string engine, int blades) : base(make, model, year, engine)
        {
            Blades = blades;
        }
    }
}
