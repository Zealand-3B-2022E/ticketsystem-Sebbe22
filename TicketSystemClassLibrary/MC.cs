using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// motorcykel version af basis classen vehicle
    /// </summary>
    public class MC : Vehicle
    {
        public override double VehiclePrice { get; set; }
        
        public MC()
        {
            VehiclePrice = 125.0;
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
                return (VehiclePrice - ((VehiclePrice / 100) * 5));
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
            return "MC";
        }
    }
}
