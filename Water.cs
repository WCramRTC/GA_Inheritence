using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Water : Transportation
    {
        public string Propulsion { get; set; }

        public Water(string make, string model, int year, string propulsion) : base(make, model, year)
        {
            Propulsion = propulsion;
        }
    } // class

} // namespace
