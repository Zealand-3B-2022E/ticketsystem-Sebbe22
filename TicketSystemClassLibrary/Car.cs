namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Bil version af basis classsen Vehicle
    /// </summary>
    public class Car : Vehicle
    {
        public override double VehiclePrice { get; set; }

        public Car()
        {
            VehiclePrice = 240.0;
        }

        /// <summary>
        /// metode som retunerer checker om kørertøjet har en brobiss og giver rabat hvis den har
        /// eller retunerer default prisen hvis den ikke har.
        /// </summary>
        /// <returns> retunerer prisen som en double. </returns>

        public override double Price()
        {
            if (Brobizz == true)
            {
                return (VehiclePrice * 0.95);
            }
            else
            {
                return VehiclePrice;
            }

        }

        /// <summary>
        /// printer hvilken type kørertøj det er
        /// </summary>
        /// <returns>retunerer en string som fortæller hvilken type kørertøj det er</returns>
        public override string VehicleType()
        {
            return "Car";
        }

    }
}