using TARpe22ShopRohusaar.Core.Domain;

namespace TARpe22ShopRohusaar.Models.Car
{
    public class CarCreateUpdateViewModel
    {
        public Guid? Id { get; set; } //unique id
        public CarType Type { get; set; } //what type of property is being sold
        public int Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public List<IFormFile> Files { get; set; } //files associated with the obj
        public List<FileToApiViewModel> FileToApiViewModels { get; set; } = new List<FileToApiViewModel>();

        //db only
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
