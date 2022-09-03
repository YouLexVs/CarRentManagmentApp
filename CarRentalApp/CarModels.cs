using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public class CarModels
    {
        public int Id { get; }
        public string LicensePlate { get; set; }
        public string CarModel { get; set; }
        public string Power { get; set; }
        public int InRent { get; set; }
        public string FullInfo
        {
            get
            {
                if (InRent == 0)
                {
                    return ($"{CarModel} \t {Power} \t {LicensePlate} \t Wolny");
                }
                else
                {
                    return ($"{CarModel} \t {Power} \t {LicensePlate} \t Zajęty");
                }
            }
        }

        public string ShortInfo
        {
            get
            {
                    return ($"{CarModel}, {LicensePlate}");
            }
        }
    }
}
