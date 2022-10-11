using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// basis classen for et kørertøj
    /// </summary>
    public abstract class Vehicle
    {
        private string _licencePlate;
        public string LicencePlate { get => _licencePlate; set { CheckLicensePlate(value); _licencePlate = value; } }
        public bool Brobizz { get; set; }
        public abstract double VehiclePrice { get; set; }
        public DateTime Date   { get; set; }

        /// <summary>
        /// metode som retunerer checker om kørertøjet har en brobiss og giver rabat hvis den har
        /// eller retunerer default prisen hvis den ikke har.
        /// </summary>
        /// <returns> retunerer prisen som en double. </returns>
        public virtual double Price()
        {
            return VehiclePrice;
        }

        /// <summary>
        /// printer hvilken type kørertøj det er
        /// </summary>
        /// <returns>retunerer en string som fortæller hvilken type kørertøj det er</returns>
        public abstract string VehicleType();

        /// <summary>
        /// tjekker om nummerpladen der er givet holder sig under 7 tegn og hvis ikke
        /// den gør så kastes der en exception
        /// </summary>
        /// <param name="plate"> den nummerplade som skal være under 7 tegn </param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void CheckLicensePlate(string plate)
        {
            if (plate.Length > 7)
            {
                throw new ArgumentOutOfRangeException("Nummerpladen må ik være længere end 7 karacterer");
            }
        }
    }
}
