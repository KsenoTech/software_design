using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace lab5mvc.Models
{
    public class MotoModel //модели бизнес-логики
    {
        [DisplayName("Brand")]
        public string Brand_name { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int id_Motorcycle { get; set; }
        [DisplayName("Цена, руб")]
        [Range(typeof(decimal), "100", "100000", ErrorMessage = "Диапазон стоимости от 100 до 100000")]
        public int Cost { get; set; }

        public int id_Type_FK { get; set; }

        [DisplayName("Тип")]
        public string TypeName { get; set; }

        public List<TypeDto> Types { get; set; }
        public MotoModel() { }
        public MotoModel(List<TypeDto> Types)
        {
            this.Types = Types;
        }
        public MotoModel(MotoDto p, List<TypeDto> Types)
        {
            id_Motorcycle = p.id_Motorcycle;
            Brand_name = p.Brand_name;
            Model = p.Model;
            Color = p.Color;
            Cost = p.Cost;
            TypeName = Types.Where(i => i.id_Type == p.id_Type_FK).FirstOrDefault().Name;
            id_Type_FK = (int)p.id_Type_FK;
            this.Types = Types; 
        }
    }
}
