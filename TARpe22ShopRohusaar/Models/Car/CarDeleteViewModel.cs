using TARpe22ShopRohusaar.Core.Domain;
using TARpe22ShopRohusaar.Models.Car;

namespace TARpe22ShopRohusaar.Models.Car
{
    public class CarDeleteViewModel
    {
        public Guid Id { get; set; } //unique id
        public CarType Type { get; set; } //what type of property is being sold
        public int Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public List<FileToApiViewModel> FileToApiViewModels { get; set; } = new List<FileToApiViewModel>();

        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
