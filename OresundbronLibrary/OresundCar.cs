using TicketSystemClassLibrary;

namespace OresundbronLibrary
{
    public class OresundCar : Vehicle
    {
        public override double VehiclePrice { get; set; }
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 161.0;
            }
            else
            {
                return 410.0;
            }
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}