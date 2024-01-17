using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Air : Transportation
    {
        // Air Property
        public string Engine { get; set; }

        // Air Constructor
        public Air(string make, string model, int year, string engine) : base(make, model, year)
        {
            Engine = engine;
        }



    } // class

} // namespace
