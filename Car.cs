using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Car : Transportation
    {
        public Car(string make, string model, int year) : base(make, model, year)
        {
        }

        // by doing colon, :, after the class name, you are inheriting from a "Base", Parent

        // Car Fields
        public int Wheels { get; set; }

        // On our constructor

        // :, colon, base(make, model)


    } // class

} // namespace
