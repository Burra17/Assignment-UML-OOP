
namespace Assignment_UML_OOP
{
    public class Reservation // Reservation klass för att hantera bokningar av fordon
    {
        public int ReservationId { get; } // Unikt ID för varje reservation
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending; // Standardstatus är "Pending"
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; } // Betalningsmetod

        public Customer Customer { get; }
        public Vehicle Vehicle { get; }

        private static int _nextId = 1; // Statisk räknare för att generera unika ID:n

        public Reservation(Customer customer, Vehicle vehicle, DateTime start, DateTime end, PaymentMethod payment) // Konstruktor
        {
            ReservationId = _nextId++; // Tilldela unikt ID och öka räknaren
            Customer = customer; 
            Vehicle = vehicle; 
            StartDate = start; 
            EndDate = end; 
            PaymentMethod = payment; 
            TotalPrice = vehicle.CalculateRentalPrice(start, end); // Beräkna totalpris baserat på fordonets pris per dag och hyresperiod
        }

        public void Confirm() => Status = ReservationStatus.Confirmed; // Metod för att bekräfta reservationen
        public void Cancel() 
        {
            Status = ReservationStatus.Cancelled; // Metod för att avbryta reservationen
            Vehicle.Availability = true; // Sätt fordonet som tillgängligt igen
            Vehicle.CurrentReservation = null; // Ta bort den nuvarande reservationen från fordonet
        }
    }

}
