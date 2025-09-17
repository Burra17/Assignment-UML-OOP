
namespace Assignment_UML_OOP
{
    public class Admin // Admin klass för att hantera fordon och kundinformation
    {
        public int AdminId { get; } // Unikt ID för varje admin
        public string Name { get; set; } 

        public Admin(int id, string name) // Konstruktor
        {
            AdminId = id;
            Name = name;
        }

        public void ManageCustomer(Customer c) { /* CRUD operations */ } // Metod för att hantera kundinformation
        public void ManageVehicle(Vehicle v) { /* CRUD operations */ } // Metod för att hantera fordon
        public Maintenance ScheduleMaintenance(Vehicle vehicle, DateTime date, string description) // Metod för att schemalägga underhåll
        {
            var m = new Maintenance(vehicle, date, description);
            vehicle.Maintenances.Add(m);
            return m;
        }
    }
}


