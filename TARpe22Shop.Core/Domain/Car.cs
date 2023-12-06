using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe22ShopRohusaar.Core.Domain
{
    public enum CarType
    {
        Sedan, Hatchback, SUV, Hybrid, Truck, Electric
    }
    public class Car
    {
        public Guid Id { get; set; } //unique id
        public CarType Type { get; set; } //what type of car is being sold
        public int Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public IEnumerable<FileToApi> FilesToApi { get; set; } = new List<FileToApi>();

        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
