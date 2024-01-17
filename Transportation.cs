using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence
{
    public class Transportation
    {
        public Transportation(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Property
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }




        // Method

        public void Start()
        {
            Console.WriteLine($"Our {Make} is starting");
        }

        public void Stop()
        {
            Console.WriteLine($"Our {Make} is stopping");
        }

    }
}
