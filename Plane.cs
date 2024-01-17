using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Plane : Air
    {
        public string WingSpan { get; set; }
        public Plane(string make, string model, int year, string engine, string wingSpan) : base(make, model, year, engine)
        {
            WingSpan = wingSpan;
        }
    }
}
