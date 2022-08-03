using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    interface IConditions
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isDelivered { get; set; }
        public bool isAvailable { get; set; }

    }
}
