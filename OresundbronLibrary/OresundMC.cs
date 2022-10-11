using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundbronLibrary
{
    public class OresundMC : Vehicle
    {
        public override double VehiclePrice { get; set; }
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 73.0;
            }
            else
            {
                return 210.0;
            }
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
