
namespace Assignment_UML_OOP
{
    public abstract class Vehicle // Abstract Vehicle klass som bas för olika fordonstyper
    { // Attribut för fordon
        public string RegistrationNumber { get; set; } 
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }
        public bool Availability { get; set; } = true

    ; public List<Maintenance> Maintenances { get; } = new(); // Lista för underhållshistorik
        public Reservation CurrentReservation { get; set; } // Nuvarande reservation om fordonet är uthyrt

        protected Vehicle(string regNo) { RegistrationNumber = regNo; } // Konstruktor

        public virtual decimal CalculateRentalPrice(DateTime start, DateTime end)
        {
            var days = (end.Date - start.Date).Days;
            if (days <= 0) days = 1;
            return days * PricePerDay;
        }
    }

}