using System;

namespace EquipmentInventory
{
    // Enum to represent types of equipment
    enum EquipmentType
    {
        Mobile,
        Immobile
    }

    // Base class for all equipment
    class Equipment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double DistanceMovedTillDate { get; protected set; } = 0;
        public double MaintenanceCost { get; protected set; } = 0;
        public EquipmentType Type { get; set; }

        // Method to move equipment by a certain distance
        public virtual void MoveBy(double distance)
        {
            DistanceMovedTillDate += distance;
            MaintenanceCost += CalculateMaintenanceCost(distance);
        }

        // Method to calculate maintenance cost
        protected virtual double CalculateMaintenanceCost(double distance)
        {
            return 0;
        }
    }

    // Concrete class for mobile equipment
    class MobileEquipment : Equipment
    {
        public int NumberOfWheels { get; set; }

        // method to calculate maintenance cost
        protected override double CalculateMaintenanceCost(double distance)
        {
            return NumberOfWheels * distance;
        }
    }

    //  class for immobile equipment
    class ImmobileEquipment : Equipment
    {
        public double Weight { get; set; }

        // method to calculate maintenance cost
        protected override double CalculateMaintenanceCost(double distance)
        {
            return Weight * distance;
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create a mobile equipment
            MobileEquipment jcb = new MobileEquipment
            {
                Name = "VENN",
                Description = "jamm",
                NumberOfWheels = 4,
                Type = EquipmentType.Mobile
            };

            // Move the mobile equipment by 10 km
            jcb.MoveBy(10);

            // Show details of the mobile equipment
            Console.WriteLine($"Name: {jcb.Name}");
            Console.WriteLine($"Description: {jcb.Description}");
            Console.WriteLine($"Distance moved till date: {jcb.DistanceMovedTillDate} km");
            Console.WriteLine($"Maintenance cost: {jcb.MaintenanceCost}");

            // Create an immobile equipment
            ImmobileEquipment ladder = new ImmobileEquipment
            {
                Name = "Ladder",
                Description = "Folding ladder",
                Weight = 5,
                Type = EquipmentType.Immobile
            };

            // Move the immobile equipment by 5 km
            ladder.MoveBy(5);

            // Show details of the immobile equipment
            Console.WriteLine($"Name: {ladder.Name}");
            Console.WriteLine($"Description: {ladder.Description}");
            Console.WriteLine($"Distance moved till date: {ladder.DistanceMovedTillDate} km");
            Console.WriteLine($"Maintenance cost: {ladder.MaintenanceCost}");

            Console.ReadKey();
        }
    }
}

