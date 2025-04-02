using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeDto
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public TypeDto() { }
        public TypeDto(DomainModel.Type t)
        {
            Id = t.Id;
            Name = t.Name;
        }
    }
}
