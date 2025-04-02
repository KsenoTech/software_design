using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace mvc.Models
{
    /// <summary>
    /// mmmm
    /// </summary>
    public class MotoModel //модели бизнес-логики
    {
        //[Key]
        public int Id { get; set; }
        [DisplayName("Brand")]
        public string Brand_name { get; set; }

        public string Model_name { get; set; }

        public string Color { get; set; }

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
            Id = p.Id;
            Brand_name = p.Brand_name;
            Model_name = p.Model_name;
            Color = p.Color;
            Cost = p.Cost;
            TypeName = Types.Where(i => i.Id == p.id_Type_FK).FirstOrDefault().Name;
            id_Type_FK = (int)p.id_Type_FK;
            this.Types = Types; 
        }
    }
}
