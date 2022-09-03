using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public class CustomerModel
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string CurrentCar { get; set; }
        public string FullInfo
        {
            get
            {
                if (CurrentCar != null)
                {
                    return $"{Id}. {FirstName} {LastName} \t Data urodzenia - {BirthDate} \t Wynajęty samochód - {CurrentCar}";
                } else
                {
                    return $"{Id}. {FirstName} {LastName} \t Data urodzenia - {BirthDate} \t Wynajęty samochód - Brak ";
                }
            }
        }
        public string ShortInfo
        {
            get
            {
                return $"{Id} {FirstName} {LastName}";
            }
        }
    }
}
