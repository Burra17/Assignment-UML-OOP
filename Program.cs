namespace Assignment_UML_OOP
{
    internal class Program 
    {
        static void Main(string[] args)
            {
            var customer = new Customer(1, "André"); // Skapar en kund
            var customer2 = new Customer(2, "Nemo"); // skapar en till kund
            var admin = new Admin(1, "SystemAdmin"); // Skapar en admin

            var car = new Car("ABC123") { Brand = "Volvo", Model = "V60", Year = 2020, PricePerDay = 500 }; // Skapar en bil
            var van = new Van("VAN001") { Brand = "Ford", Model = "Transit", Year = 2019, PricePerDay = 800 }; // Skapar en van

                // Admin schemalägger service för van
            admin.ScheduleMaintenance(van, DateTime.Today.AddDays(7), "Oil change");

                // Kund gör reservation
            var start = DateTime.Today.AddDays(1); // Imorgon
            var end = DateTime.Today.AddDays(4); // Om fyra dagar
            var reservation = customer.MakeReservation(car, start, end, PaymentMethod.CreditCard); // Gör en reservation
            reservation.Confirm(); // Bekräftar reservationen

            // Andra bokningen: annan kund och van
            var start2 = DateTime.Today.AddDays(2);
            var end2 = DateTime.Today.AddDays(5);

            // Bokar van med customer2
            var reservation2 = customer2.MakeReservation(van, start2, end2, PaymentMethod.CreditCard);
            reservation2.Confirm();


            Console.WriteLine($"Reservation {reservation.ReservationId} for {reservation.Vehicle.RegistrationNumber} total {reservation.TotalPrice} SEK"); // Skriver ut reservationens detaljer

            Console.WriteLine($"Reservation {reservation2.ReservationId} for {reservation2.Vehicle.RegistrationNumber} total {reservation2.TotalPrice} SEK"); // Skriver ut reservationens detaljer för skåpbilen

        }

    }
}
    

