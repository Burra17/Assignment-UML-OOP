
namespace Assignment_UML_OOP
{
    public class Van : Vehicle // Van subklass som ärver från Vehicle
    {
        public decimal CargoVolume { get; set; } // Attribut för lastvolym
        public decimal MaxLoad { get; set; } // Attribut för maxlast

        public Van(string regNo) : base(regNo) { } // Konstruktor som anropar basklassens konstruktor
    }

}