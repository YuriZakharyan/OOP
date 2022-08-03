using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    class KFC:Restaurant, IConditions
    {

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isDelivered { get; set; }
        public bool isAvailable { get; set; }

        public override void Deliver(int foodType)
        {
        }


        public override void ReturnFood()
        {
        }
    }
}
