using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ManufacturerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ManufacturerDto() { }
        public ManufacturerDto(Manufacturer m)
        {
            Id = m.Id;
            Name = m.Name;
        }
    }
}
