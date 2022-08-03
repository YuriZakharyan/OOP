using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    interface IInfo
    {
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public int Caloria { get; set; }
    }
}
