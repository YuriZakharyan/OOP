namespace Restaurant_Project
{
    class PitStop : Restaurant,IConditions
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
