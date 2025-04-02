
using DomainModel;

namespace DTO
{
    public class PhoneDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public int ManufacturerId { get; set; }
        public string Description { get; set; }

        public PhoneDto() { }
        public PhoneDto(Phone p) {
            Id = p.Id;
            Name = p.Name;
            Cost = p.Cost;
            ManufacturerId = p.ManufacturerId;
            Description = p.Description;
        }
    }
}
