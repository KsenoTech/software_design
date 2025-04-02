using System;
using DAL.NewFolder1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class TypeDto
    {
        public string Name { get; set; }
        public int id_Type { get; set; }

        public TypeDto() { }
        public TypeDto(DAL.NewFolder1.Type t)
        {
            id_Type = t.id_Type;
            Name = t.Name;
        }
    }
}
