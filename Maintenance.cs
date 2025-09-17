using Assignment_UML_OOP;

public class Maintenance // Maintenance klass för att hantera underhåll av fordon
{
    public int MaintenanceId { get; } // Unikt ID för varje underhållspost
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public Vehicle Vehicle { get; }

    private static int _nextId = 1; // Statisk räknare för att generera unika ID:n

    public Maintenance(Vehicle vehicle, DateTime date, string description) // Konstruktor
    {
        MaintenanceId = _nextId++;
        Vehicle = vehicle;
        Date = date;
        Description = description;
    }

    public void ScheduleMaintenance(DateTime newDate) // Metod för att schemalägga om underhållet
    {
        Date = newDate;
    }
}


