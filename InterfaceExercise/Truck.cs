using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public Truck() { }


        public string Make { get; set; } = "Chevrolet";
        public string Model { get; set; } = "Silverado";
        public string Year { get; set; } = "2023";
        public decimal EngineSize { get; set; } = 8.0m;
        public string CoName { get; set; } = "General Motors";
        public string Country { get; set; } = "USA";
        public int NumberOfSeats { get; set; } = 5;
        public bool CanTow { get; set; } = true;
        public double TireSize { get; set; } = 275.70;
        public void PrintStats()
        {
            Console.WriteLine($"{CoName}");
            Console.WriteLine($"{Country}");
            Console.WriteLine($"------------------------");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Engine Size: {EngineSize}");
            Console.WriteLine($"Number of Seats: {NumberOfSeats}");
            Console.WriteLine($"Tire Size: {TireSize}");
            Console.WriteLine($"Can Tow: {CanTow}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
