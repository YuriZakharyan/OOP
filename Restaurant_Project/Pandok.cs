using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    class Pandok : Restaurant,IConditions
    {
        public int[] MenuList = new int[] { 0, 1, 3 }; 
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isDelivered { get; set; }
        public bool isAvailable { get; set; }

        public override void Deliver(int foodType)
        {
            for (int i = 0; i < MenuList.Length; i++)
            {
                if(foodType == MenuList[i])
                {



                }
            }
        }
        public override void ReturnFood()
        {


        }
    }
}
