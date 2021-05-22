namespace FunctionalConcepts
{
    /// <summary>
    /// Objects initialisers are a way of setting properties for a type on the
    /// same line of code as you instantiate that type.
    /// </summary>
    public class ObjectInitialisers
    {
        public static void Demonstrate()
        {
            var h1 = new House();
            var h2 = new House();
            var h3 = new House();

            h1.NumberOfBathrooms = 2;
            h2.ExternalPaintColor = "Brown";
            h3.ExternalPaintColor = "Yellow";
            h3.NumberOfFloors = 3;

            // *** VERSUS *** //

            var h4 = new House {NumberOfBathrooms = 2};
            var h5 = new House {ExternalPaintColor = "Brown"};
            var h6 = new House {ExternalPaintColor = "Yellow", NumberOfFloors = 3};
        }
    }

    public class House
    {
        public int NumberOfFloors { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string ExternalPaintColor { get; set; }
    }
}