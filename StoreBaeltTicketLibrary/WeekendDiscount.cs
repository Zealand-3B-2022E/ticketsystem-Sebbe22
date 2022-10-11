using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class WeekendDiscount
    {
        /// <summary>
        /// tager et kørertøj og beregner prisen for at krydse storebælt (prisen er afhænig
        /// af om man krydser broen i weekenden eller hverdagen)
        /// 
        /// </summary>
        /// <param name="vehicle"> det køretøj som krydser broen </param>
        /// <returns> retunerer prisen for at krydste broen som en double. </returns>
        public double StoreBaeltDiscount(Vehicle vehicle)
        {
            if (vehicle.Date.DayOfWeek == DayOfWeek.Sunday || vehicle.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                vehicle.VehiclePrice = (vehicle.VehiclePrice * (0.8));
                return Math.Round(vehicle.Price(),2);
            }
            else
            {
                return vehicle.Price();
            }
        }
    }
}