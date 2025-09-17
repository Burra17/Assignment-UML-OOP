
namespace Assignment_UML_OOP
{
    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        Cash,
        MobilePayment
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Completed
    }

    public class Customer // Kundklass för att hantera kundinformation och reservationer
    {
        private readonly List<Reservation> _reservations = new(); // Lista för kundens reservationer
        private readonly int _customerId; // privata fält
        private string _name;
        private string _phoneNumber;
        private string _email;

        public int CustomerId => _customerId; // offentliga egenskaper
        public string Name => _name;
        public string PhoneNumber => _phoneNumber;
        public string Email => _email;
        public IReadOnlyList<Reservation> Reservations => _reservations.AsReadOnly(); // Läsbar lista över kundens reservationer

        public Customer(int id, string name) // Konstruktor
        {
            _customerId = id;
            _name = name ?? throw new ArgumentNullException(nameof(name)); // Kontroll för null-värde
        }

        public void UpdateContact(string phoneNumber, string email) // Metod för att uppdatera kontaktinformation
        {
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public Reservation MakeReservation(Vehicle vehicle, DateTime start, DateTime end, PaymentMethod payment) // Metod för att skapa en reservation
        {
            if (start >= end) throw new ArgumentException("Start must be before end", nameof(start));
            if (!vehicle.Availability) throw new InvalidOperationException("Vehicle not available");

            var res = new Reservation(this, vehicle, start, end, payment);
            _reservations.Add(res);
            vehicle.CurrentReservation = res;
            vehicle.Availability = false;
            return res;
        }
    }
}